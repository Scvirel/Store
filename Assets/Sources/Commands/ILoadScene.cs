using UnityEngine.SceneManagement;

namespace Store.Client
{
    public interface ILoadScene : INoResponseCommand<string, LoadSceneMode>
    { }
}
