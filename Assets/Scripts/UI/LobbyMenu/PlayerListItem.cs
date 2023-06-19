using TMPro;
using UnityEngine;

namespace Rummicub.UI.LobbyMenu
{
    public class PlayerListItem : MonoBehaviour
    {
        public TMP_Text PlayerNameText;

        public void SetPlayerName(string playerName)
        {
            PlayerNameText.text = playerName;
        }
    }
}
