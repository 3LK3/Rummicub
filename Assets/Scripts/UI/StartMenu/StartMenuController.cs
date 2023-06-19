using UnityEngine;

namespace Rummicub.UI.StartMenu
{
    public class StartMenuController : MonoBehaviour
    {
        public GameObject MainMenuPanel;
        public GameObject SettingsMenuPanel;
        public GameObject JoinGameMenuPanel;
        public GameObject HostGameMenuPanel;

        private GameObject _activeMenu;

        private void OnEnable()
        {
            _activeMenu = MainMenuPanel;
        }

        public void ShowMainMenu() => ActivateNewMenu(MainMenuPanel);

        public void ShowSettingsMenu() => ActivateNewMenu(SettingsMenuPanel);

        public void ShowJoinGameMenu() => ActivateNewMenu(JoinGameMenuPanel);

        public void ShowHostGameMenu() => ActivateNewMenu(HostGameMenuPanel);

        private void ActivateNewMenu(GameObject menuPanel)
        {
            _activeMenu.SetActive(false);
            _activeMenu = menuPanel;
            _activeMenu.SetActive(true);
        }
    }
}
