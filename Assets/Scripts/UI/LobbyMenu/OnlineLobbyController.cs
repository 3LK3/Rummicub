using Unity.Services.Authentication;
using UnityEngine;

namespace Rummicub.UI.LobbyMenu
{
    public class OnlineLobbyController : MonoBehaviour
    {
        public LobbiesMenuController LobbiesMenu;
        public InLobbyMenuController InLobbyMenu;

        private GameObject _activeMenu;

        private void Start()
        {
            AuthenticationService.Instance.SignedIn += OnAuthenticationServiceSignedIn;

            AuthenticationManager.Instance.SignInAnonymously();
        }

        private void OnEnable()
        {
            _activeMenu = LobbiesMenu.gameObject;
        }

        public void ActivateNewMenu(GameObject menuPanel)
        {
            _activeMenu.SetActive(false);
            _activeMenu = menuPanel;
            _activeMenu.SetActive(true);
        }

        private void OnAuthenticationServiceSignedIn()
        {
            Debug.Log($"Signed in - {AuthenticationService.Instance.PlayerId}");

            if (LobbiesMenu.TryGetComponent<LobbiesMenuController>(out var lobbyListMenuController))
            {
                //lobbyListMenuController.UpdateLobbyList();
            }
        }
    }
}
