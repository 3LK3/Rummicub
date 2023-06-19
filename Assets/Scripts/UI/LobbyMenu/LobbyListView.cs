using System;
using System.Collections.Generic;
using Unity.Services.Lobbies.Models;
using UnityEngine;

namespace Rummicub.UI.LobbyMenu
{
    public class LobbyListView : MonoBehaviour
    {
        public GameObject ListViewContent;
        public GameObject LobbyItemPrefab;
        public GameObject NoLobbyFoundText;

        //[HideInInspector]
        //public event Action<SelectedEventArgs> Selected;

        //[HideInInspector]
        //public Lobby SelectedLobby
        //{
        //    get
        //    {
        //        if (m_selectedObject == null)
        //        {
        //            return null;
        //        }
        //        return m_selectedObject.GetComponent<LobbyListItem>().Lobby;
        //    }
        //}

        //private readonly List<GameObject> m_listObjects = new();
        //private GameObject m_selectedObject;

        //private void OnDestroy()
        //{
        //    foreach (var item in m_listObjects)
        //    {
        //        UnregisterItem(item.GetComponent<LobbyListItem>());
        //    }
        //}

        //public void AddLobby(Lobby lobby)
        //{
        //    var lobbyItem = Instantiate(LobbyItemPrefab, ListViewContent.transform);

        //    var listItem = lobbyItem.GetComponent<LobbyListItem>();
        //    listItem.SetLobby(lobby);
        //    RegisterItem(listItem);

        //    m_listObjects.Add(lobbyItem);
        //}

        //public void EnableNoResultInfo(bool enabled = true)
        //{
        //    NoLobbyFoundText.SetActive(enabled);
        //}

        //private void OnItemSelected(SelectedEventArgs args)
        //{
        //    if (m_selectedObject != null)
        //    {
        //        m_selectedObject.GetComponent<LobbyListItem>().SetSelected(false);
        //    }

        //    foreach (var item in m_listObjects)
        //    {
        //        if (item.GetComponent<LobbyListItem>().Lobby.Id == args.Lobby.Id)
        //        {
        //            m_selectedObject = item;
        //            m_selectedObject.GetComponent<LobbyListItem>().SetSelected(true);

        //            Selected?.Invoke(new SelectedEventArgs(args.Lobby));

        //            break;
        //        }
        //    }
        //}

        //public void Clear()
        //{
        //    foreach (var item in m_listObjects)
        //    {
        //        UnregisterItem(item.GetComponent<LobbyListItem>());
        //        Destroy(item);
        //    }
        //}

        //private void RegisterItem(LobbyListItem item)
        //{
        //    item.Selected += OnItemSelected;
        //}

        //private void UnregisterItem(LobbyListItem item)
        //{
        //    item.Selected -= OnItemSelected;
        //}
    }
}
