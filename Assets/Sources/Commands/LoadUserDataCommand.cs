using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace Store.Client
{
    public sealed class LoadUserDataCommand : ILoadUserData
    {
        public UserDataDto Invoke(SaveLoadType type)
        {
            switch (type)
            {
                case SaveLoadType.Json:
                    {
                        string filePath = Path.Combine(Application.persistentDataPath, Paths.UserDataJson);

                        if (File.Exists(filePath))
                        {
                            return JsonUtility.FromJson<UserDataDto>(File.ReadAllText(filePath));
                        }
                        else
                        {
                            return new UserDataDto(0, 0);
                        }
                    }

                case SaveLoadType.PlayerPrefs:
                    {
                        if (PlayerPrefs.HasKey(Paths.UserDataPrefs))
                        {
                            return JsonUtility.FromJson<UserDataDto>(PlayerPrefs.GetString(Paths.UserDataPrefs));
                        }
                        else
                        {
                            return new UserDataDto(0, 0);
                        }
                    }

                case SaveLoadType.Base64:
                    {
                        string filePath = Path.Combine(Application.persistentDataPath, Paths.UserDataBase64);

                        if (File.Exists(filePath))
                        {
                            return JsonUtility.FromJson<UserDataDto>(
                                       Encoding.UTF8.GetString(
                                           Convert.FromBase64String(
                                               File.ReadAllText(filePath)
                                               )
                                           )
                                       );
                        }
                        else
                        {
                            return new UserDataDto(0, 0);
                        }
                    }

                default:
                    return default;
            }
        }
    }
}
