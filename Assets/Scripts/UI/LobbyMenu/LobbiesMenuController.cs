using Rummicub.SceneManagement;
using Unity.Services.Authentication;
using UnityEngine;
using UnityEngine.UI;

namespace Rummicub.UI.LobbyMenu
{
    public class LobbiesMenuController : MonoBehaviour
    {
        public LobbyListView LobbyListView;
        //public GameObject CreateLobbyDialog;
        public GameObject JoinButton;


        //public async void UpdateLobbyList()
        //{
        //    var queryResponse = await Lobbies.Instance.QueryLobbiesAsync();
        //    Debug.Log($"Found {queryResponse.Results.Count} lobbies");

        //    LobbyListView.Clear();

        //    if (queryResponse.Results.Count == 0)
        //    {
        //        LobbyListView.EnableNoResultInfo();
        //        return;
        //    }

        //    LobbyListView.EnableNoResultInfo(false);

        //    foreach (var lobby in queryResponse.Results)
        //    {
        //        LobbyListView.AddLobby(lobby);
        //    }
        //}

        private void OnLobbySelected(SelectedEventArgs args)
        {
            JoinButton.GetComponent<Button>().interactable = true;
        }

        public void JoinSelectedLobby()
        {
            //var lobby = LobbyListView.SelectedLobby;

            //LobbyController.JoinLobby(lobby.Id);
        }

        //public void CreateLobby()
        //{
        //    var userName = PlayerPrefs.GetString(RummicubPreferences.PlayerNameKey, null);
        //    if (string.IsNullOrEmpty(userName))
        //    {
        //        throw new Exception("No user name set. Make sure there is a user name assigned.");
        //    }

        //    var initialLobbyName = $"{userName}'s Lobby";
        //    CreateLobbyDialog.SetActive(true);

        //    var createLobbyDialog = CreateLobbyDialog.GetComponent<CreateLobbyDialog>();
        //    createLobbyDialog.SetLobbyName(initialLobbyName);
        //    createLobbyDialog.LobbyCreated += OnLobbyCreated;
        //    createLobbyDialog.Cancelled += OnLobbyCreationCancelled;
        //}

        private void OnLobbyCreationCancelled()
        {
            //CreateLobbyDialog.SetActive(false);
        }

        private void OnLobbyCreated(string lobbyName)
        {
            //CreateLobbyDialog.SetActive(false);

            //var createLobbyDialog = CreateLobbyDialog.GetComponent<CreateLobbyDialog>();
            //createLobbyDialog.LobbyCreated -= OnLobbyCreated;

            //LobbyController.CreateAndJoinLobby(lobbyName);
        }

        public void GoBack()
        {
            if (AuthenticationService.Instance.IsSignedIn)
            {
                AuthenticationService.Instance.SignOut();
            }

            SceneTransitionHandler.Instance.SwitchScene(SceneState.StartMenu);
        }
    }
}
