using Rummicub.SceneManagement;
using UnityEngine;

namespace Rummicub.UI.StartMenu
{
    public class MainMenuController : MonoBehaviour
    {
        public StartMenuController StartMenuController;

        public void ShowOnlineLobby()
        {
            SceneTransitionHandler.Instance.SwitchScene(SceneState.Lobby);
        }

        public void ShowSettingsMenu() => StartMenuController.ShowSettingsMenu();

        // Start is called before the first frame update
        public void QuitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}