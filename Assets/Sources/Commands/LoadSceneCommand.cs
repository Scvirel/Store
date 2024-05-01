using System;
using UnityEngine.SceneManagement;

namespace Store.Client
{
    public sealed class LoadSceneCommand : ILoadScene
    {
        public void Invoke(string name, LoadSceneMode mode)
        {
            try
            {
                SceneManager.LoadSceneAsync(name, mode);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception.InnerException);
            }
        }
    }
}
