using Newtonsoft.Json;
using System;
using System.IO;
using UnityEngine;

namespace Rummicub.Gameplay.Settings
{
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager Instance;

        private string m_settingsPath;
        private PlayerData m_playerData;

        private void Awake()
        {
            AwakeSingleton();

            m_settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "3lk3", "Rummicub");
            if (!Directory.Exists(m_settingsPath))
            {
                Debug.Log($"Settings folder does not exist. Creating folder: {m_settingsPath}");
                Directory.CreateDirectory(m_settingsPath);
            }
        }

        private void AwakeSingleton()
        {
            if (Instance != null && Instance != this)
            {
                GameObject.Destroy(Instance.gameObject);
            }

            Instance = this;
            DontDestroyOnLoad(this);
        }

        public PlayerData GetPlayerData()
        {
            return m_playerData ??= ReadPlayerData();
        }

        public void SavePlayerData(PlayerData playerData)
        {
            var jsonContent = JsonConvert.SerializeObject(playerData);
            File.WriteAllText(GetSettingsFilePath("PlayerData.json"), jsonContent);
        }

        private PlayerData ReadPlayerData()
        {
            var filePath = GetSettingsFilePath("PlayerData.json");
            if (!File.Exists(filePath))
            {
                SavePlayerData(new PlayerData());
            }

            var jsonContent = File.ReadAllText(filePath);
            if (string.IsNullOrEmpty(jsonContent))
            {
                SavePlayerData(new PlayerData());
                jsonContent = File.ReadAllText(filePath);
            }

            return JsonConvert.DeserializeObject<PlayerData>(jsonContent);
        }

        private string GetSettingsFilePath(string fileName)
        {
            return Path.Combine(m_settingsPath, fileName);
        }
    }
}
