using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Store.Client
{
    public sealed class SaveUserDataCommand : ISaveUserData
    {
        public void Invoke(SaveLoadType type, UserDataDto dto)
        {
            switch (type)
            {
                case SaveLoadType.Json: 
                    {
                        string filePath = Path.Combine(Application.persistentDataPath, Paths.UserDataJson);

                        File.WriteAllText(filePath, JsonUtility.ToJson(dto));
                    } 
                    break;

                case SaveLoadType.PlayerPrefs: 
                    {
                        PlayerPrefs.SetString(Paths.UserDataPrefs, JsonUtility.ToJson(dto));
                        PlayerPrefs.Save();
                    }
                    break;

                case SaveLoadType.Base64: 
                    {
                        string filePath = Path.Combine(Application.persistentDataPath, Paths.UserDataBase64);

                        File.WriteAllText(
                            filePath,
                            Convert.ToBase64String(
                                Encoding.UTF8.GetBytes(
                                    JsonUtility.ToJson(dto)
                                    )
                                )
                            );
                    }
                    break;
            }
        }
    }
}
