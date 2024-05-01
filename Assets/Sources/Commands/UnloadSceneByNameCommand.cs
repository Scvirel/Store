using UnityEngine.SceneManagement;

namespace Store.Client
{
    public sealed class UnloadSceneByNameCommand : IUnloadSceneByName
    {
        public void Invoke(string input)
        {
            SceneManager.UnloadSceneAsync(
                SceneManager.GetSceneByName(input)
                );
        }
    }
}
