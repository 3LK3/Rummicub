using System;
using TMPro;
using UnityEngine;

namespace Rummicub.UI.LobbyMenu
{
    public class CreateLobbyDialog : MonoBehaviour
    {
        public TMP_InputField LobbyNameInput;

        public event Action<string> LobbyCreated;
        public event Action Cancelled;

        public void SetLobbyName(string lobbyName)
        {
            LobbyNameInput.text = lobbyName;
        }

        public void Cancel()
        {
            Cancelled?.Invoke();
        }

        public void CreateAndJoinLobby()
        {
            LobbyCreated?.Invoke(LobbyNameInput.text);
        }
    }
}
