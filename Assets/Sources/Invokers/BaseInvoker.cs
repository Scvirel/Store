using System;
using UnityEngine;

namespace Store.Client
{
    public abstract class BaseInvoker : MonoBehaviour, IInvoker
    {
        [SerializeField] private Instruction[] _instructions = default;
        [SerializeField] private RunnerType _runnerType = default;

        public async virtual void Execute()
        {
            try
            {
                switch (_runnerType)
                {
                    case RunnerType.Synchronous:
                        new Runner().DefaultRun(_instructions);
                        break;
                    case RunnerType.Asynchronous:
                        await new Runner().AsyncRun(_instructions);
                        break;
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception.InnerException);
            }
        }
    }
}
