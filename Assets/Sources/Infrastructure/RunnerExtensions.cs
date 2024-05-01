using System.Threading.Tasks;
using UnityEngine;

namespace Store.Client
{
    public static class RunnerExtensions
    {
        public static void DefaultRun(this Runner runner, params IMonoInstruction[] instructions)
        {
            foreach (Instruction instruction in instructions)
            {
                instruction.Invoke();

                if (instruction.Status == ProcessingStatus.Failed)
                {
                    break;
                }
            }
        }

        public static void DefaultTargetRun<TTarget>(this Runner runner, TTarget input, params IMonoInstruction<TTarget>[] instructions)
        {
            foreach (Instruction<TTarget> instruction in instructions)
            {
                instruction.Invoke(input);

                if (instruction.Status == ProcessingStatus.Failed)
                {
                    break;
                }
            }
        }

        public static async Task AsyncRun(this Runner runner, params IMonoInstruction[] instructions)
        {
            foreach (Instruction instruction in instructions)
            {
                instruction.Invoke();

                while (instruction.Status == ProcessingStatus.Running)
                {
                    await Awaitable.WaitForSecondsAsync(1f);
                }

                if (instruction.Status == ProcessingStatus.Failed)
                {
                    break;
                }
            }
        }

        public static async Task AsyncTargetRun<TTarget>(this Runner runner, TTarget input, params IMonoInstruction<TTarget>[] instructions)
        {
            foreach (Instruction<TTarget> instruction in instructions)
            {
                instruction.Invoke(input);

                while (instruction.Status == ProcessingStatus.Running)
                {
                    await Awaitable.WaitForSecondsAsync(1f);
                }

                if (instruction.Status == ProcessingStatus.Failed)
                {
                    break;
                }
            }
        }
    }
}
