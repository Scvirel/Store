using System;
using UnityEngine;

namespace Store.Client
{
    public abstract class BaseTargetInvoker<Type> : MonoBehaviour, ITargetInvoker<Type>
    {
        [SerializeField] private Instruction<Type>[] _instructions = default;
        [SerializeField] private RunnerType _runnerType = default;

        public async virtual void Execute(Type input)
        {
            try
            {
                switch (_runnerType)
                {
                    case RunnerType.Synchronous:
                        new Runner().DefaultTargetRun(input, _instructions);
                        break;
                    case RunnerType.Asynchronous:
                        await new Runner().AsyncTargetRun(input, _instructions);
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
