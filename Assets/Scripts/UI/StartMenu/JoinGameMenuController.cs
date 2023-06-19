using UnityEngine;

namespace Rummicub.UI.StartMenu
{
    public class JoinGameMenuController : MonoBehaviour
    {
        public StartMenuController StartMenuController;

        private void OnEnable()
        {
            Debug.Log("JoinMenu :: OnEnable");
        }

        private void OnDisable()
        {
            Debug.Log("JoinMenu :: OnDisable");
        }

        public void GoBack() => StartMenuController.ShowMainMenu();
    }
}
