using Rummicub.Gameplay;
using Rummicub.Gameplay.Settings;
using TMPro;
using UnityEngine;

namespace Rummicub.UI.StartMenu
{
    public class SettingsMenuController : MonoBehaviour
    {
        public StartMenuController StartMenuController;

        public TMP_InputField PlayerNameInput;
        private PlayerData m_playerData;

        private void OnEnable()
        {
            Debug.Log("SettingsMenu :: OnEnable");

            m_playerData = SettingsManager.Instance.GetPlayerData();
            PlayerNameInput.text = m_playerData.Name;
        }

        public void SaveAndGoBack()
        {
            m_playerData.Name = PlayerNameInput.text;
            SettingsManager.Instance.SavePlayerData(m_playerData);

            //PlayerPrefs.SetString(RummicubPreferences.PlayerNameKey, PlayerNameInput.text);
            //PlayerPrefs.Save();

            GoBack();
        }

        public void GoBack() => StartMenuController.ShowMainMenu();
    }
}
