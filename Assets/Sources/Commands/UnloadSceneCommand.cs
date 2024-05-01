using UnityEngine.SceneManagement;

namespace Store.Client
{
    public sealed class UnloadSceneCommand : IUnloadScene
    {
        public void Invoke(Scene input)
        {
            SceneManager.UnloadSceneAsync(input);
        }
    }
}
