using System;
using TMPro;
using Unity.Services.Lobbies.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Rummicub.UI.LobbyMenu
{
    public class SelectedEventArgs
    {
        public Lobby Lobby;

        public SelectedEventArgs(Lobby lobby)
        {
            Lobby = lobby;
        }
    }

    [RequireComponent(typeof(Button))]
    public class LobbyListItem : MonoBehaviour
    {
        public TMP_Text LobbyNameText;
        public TMP_Text LobbyPlayersText;

        public Color SelectedColor;

        [HideInInspector]
        public event Action<SelectedEventArgs> Selected;

        [HideInInspector]
        public Lobby Lobby => m_lobby;

        private Color m_defaultColor;
        private Color m_selectedColor;

        private bool m_isSelected;
        private Lobby m_lobby;

        private void Awake()
        {
            m_isSelected = false;
            m_defaultColor = GetComponent<Image>().color;
            m_selectedColor = SelectedColor;
        }

        public void Select()
        {
            SetSelected(m_isSelected = true);

            Selected?.Invoke(new SelectedEventArgs(m_lobby));
        }

        public void SetLobby(Lobby lobby)
        {
            m_lobby = lobby;

            SetLobbyName(m_lobby.Name);
            SetLobbyPlayers(m_lobby.MaxPlayers - m_lobby.AvailableSlots, m_lobby.MaxPlayers);
        }

        public void SetLobbyName(string lobbyName)
        {
            LobbyNameText.text = lobbyName;
        }

        public void SetLobbyPlayers(int actualPlayerCount, int maxPlayerCount)
        {
            LobbyPlayersText.text = $"{actualPlayerCount} / {maxPlayerCount}";
        }

        public void SetSelected(bool selected)
        {
            m_isSelected = selected;
            GetComponent<Image>().color = m_isSelected ? m_selectedColor : m_defaultColor;
        }
    }
}
