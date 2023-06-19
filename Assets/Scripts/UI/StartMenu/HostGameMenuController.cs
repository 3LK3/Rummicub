using Rummicub.Gameplay;
using Rummicub.SceneManagement;
using Rummicub.UI.Common;
using Unity.Netcode;
using UnityEngine;

namespace Rummicub.UI.StartMenu
{
    public class HostGameMenuController : MonoBehaviour
    {
        public StartMenuController StartMenuController;

        public NumberSlider MaxPlayerCountSlider;

        private void OnEnable()
        {
            Debug.Log("HostGame :: OnEnable");

            var maximumPlayerCount = GamePreferences.Instance.MaximumPlayerCount;
            MaxPlayerCountSlider.SetValue(maximumPlayerCount);
        }

        public void StartGame()
        {
            GamePreferences.Instance.MaximumPlayerCount = MaxPlayerCountSlider.GetValue();

            if (NetworkManager.Singleton.StartHost())
            {
                SceneTransitionHandler.Instance.SwitchScene(SceneState.Lobby);
            }
        }

        public void GoBack() => StartMenuController.ShowMainMenu();
    }
}
