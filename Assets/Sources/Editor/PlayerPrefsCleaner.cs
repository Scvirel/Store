using UnityEditor;
using UnityEngine;

namespace Store.Client
{
    public sealed class PlayerPrefsCleaner : Editor
    {
        [MenuItem("CustomEditor/Clear Prefs")]
        private static void ClearPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}