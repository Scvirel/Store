using System;
using UnityEngine;

namespace Store.Client
{
    public abstract class Instruction : MonoBehaviour, IMonoInstruction
    {
        protected ProcessingStatus _status = default;
        public ProcessingStatus Status
        {
            get => _status;
        }

        public void Complete()
        {
            _status = ProcessingStatus.Success;
        }

        public void Invoke()
        {
            try
            {
                _status = ProcessingStatus.Running;
                Process();
            }
            catch (Exception exception)
            {
                Debug.LogError($"{nameof(Instruction)} on {gameObject.name} throw : {exception}");

                _status = ProcessingStatus.Failed;

                throw exception;
            }
        }

        public abstract void Process();

        public override string ToString()
        {
            return $"{gameObject.name} on {gameObject.scene.name} scene";
        }
    }

    public abstract class Instruction<TInput> : MonoBehaviour, IMonoInstruction<TInput>
    {
        protected ProcessingStatus _status = default;
        public ProcessingStatus Status
        {
            get => _status;
        }

        public void Complete()
        {
            _status = ProcessingStatus.Success;
        }

        public void Invoke(TInput input)
        {
            try
            {
                _status = ProcessingStatus.Running;
                Process(input);
            }
            catch (Exception exception)
            {
                Debug.LogError($"{nameof(Instruction)} on {gameObject.name} throw : {exception}");

                _status = ProcessingStatus.Failed;

                throw exception;
            }
        }

        public abstract void Process(TInput input);

        public override string ToString()
        {
            return $"{gameObject.name} on {gameObject.scene.name} scene";
        }
    }
}
