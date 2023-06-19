using System.Collections.Generic;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Rummicub.UI.LobbyMenu
{
    public class InLobbyMenuController : MonoBehaviour
    {
        public float LobbyHeartbeatPingIntervalSeconds = 15f;
        public float LobbyUpdateIntervalSeconds = 2f;

        public GameObject StartGameButton;

        [Header("Player List")]
        public PlayerListView PlayerListView;
        public GameObject PlayerListItemPrefab;

        private readonly List<GameObject> m_playerListItems = new();
        private Lobby m_lobby;
        private bool m_isHost = false;

        private float m_heartbeatTimeRemaining = -1f;
        private float m_lobbyUpdateTimeRemaining = -1f;

        private void OnEnable()
        {
            if (m_isHost)
            {
                StartGameButton.GetComponent<Button>().interactable = true;
            }
        }

        private void Update()
        {
            if (m_isHost)
            {
                HandleLobbyHeartbeatPing();
            }

            HandleLobbyUpdate();
        }

        private async void HandleLobbyUpdate()
        {
            m_lobbyUpdateTimeRemaining -= Time.deltaTime;
            if (m_lobbyUpdateTimeRemaining >= 0)
            {
                return;
            }

            m_lobbyUpdateTimeRemaining = LobbyUpdateIntervalSeconds;

            Debug.Log("Updating lobby");
            m_lobby = await Lobbies.Instance.GetLobbyAsync(m_lobby.Id);

            UpdatePlayerList();
        }

        private void UpdatePlayerList()
        {
            PlayerListView.SetPlayers(m_lobby.Players);

            //ClearPlayerList();

            //foreach (var player in m_lobby.Players)
            //{
            //    var playerItem = Instantiate(PlayerListItemPrefab, PlayerListViewContent.transform);
            //    var listItem = playerItem.GetComponent<PlayerListItem>();
            //    listItem.SetPlayerName(player.Data["PlayerName"].Value);

            //    m_playerListItems.Add(playerItem);
            //}
        }

        private void ClearPlayerList()
        {
            foreach (var item in m_playerListItems)
            {
                Destroy(item);
            }
        }

        private async void HandleLobbyHeartbeatPing()
        {
            if (m_lobby == null)
            {
                return;
            }

            m_heartbeatTimeRemaining -= Time.deltaTime;
            if (m_heartbeatTimeRemaining >= 0f)
            {
                return;
            }

            m_heartbeatTimeRemaining = LobbyHeartbeatPingIntervalSeconds;

            Debug.Log("Sending lobby heartbeat ping");
            await LobbyService.Instance.SendHeartbeatPingAsync(m_lobby.Id);
        }

        public void SetLobby(Lobby lobby)
        {
            m_lobby = lobby;
        }

        public void SetAsHost()
        {
            m_isHost = true;
        }
    }
}
