using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Lobbies.Models;
using UnityEngine;

namespace Rummicub
{
    public class PlayerListView : MonoBehaviour
    {
        public GameObject[] PlayerItems;

        public void SetPlayers(List<Player> players)
        {
            for (int i = 0; i < PlayerItems.Length; i++)
            {
                if (players.Count > i)
                {
                    var player = players[i];
                    Debug.Log("There is a player at " + i);

                    PlayerItems[i].GetComponentInChildren<TMP_Text>().text = player.Data["PlayerName"].Value;
                }
                else
                {
                    PlayerItems[i].GetComponentInChildren<TMP_Text>().text = "-";
                }
            }
        }
    }
}
