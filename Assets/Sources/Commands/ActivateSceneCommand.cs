using UnityEngine.SceneManagement;

namespace Store.Client
{
    public sealed class ActivateSceneCommand : IActivateScene
    {
        public void Invoke(string input)
        {
            SceneManager.SetActiveScene(
                SceneManager.GetSceneByName(input)
                );
        }
    }
}
