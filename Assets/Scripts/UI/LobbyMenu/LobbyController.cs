using UnityEngine;

namespace Rummicub.UI.LobbyMenu
{
    public class LobbyController : MonoBehaviour
    {
        //public int MaxPlayerCount = 4;

        //public async void JoinLobby(string lobbyId)
        //{
        //    Debug.Log("LobbyController :: JoinLobby");

        //    var joinOptions = new JoinLobbyByIdOptions
        //    {
        //        Player = GetPlayer()
        //    };

        //    var joinedLobby = await LobbyService.Instance.JoinLobbyByIdAsync(lobbyId, joinOptions);
        //    Debug.Log("Joined lobby");

        //    InLobbyMenu.SetLobby(joinedLobby);

        //    ActivateNewMenu(InLobbyMenu.gameObject);
        //}

        //public async void CreateAndJoinLobby(string lobbyName)
        //{
        //    Debug.Log("LobbyController :: CreateAndJoinLobby");

        //    var lobbyOptions = new CreateLobbyOptions
        //    {
        //        IsPrivate = false,
        //        Player = GetPlayer()
        //    };

        //    var hostedLobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, MaxPlayerCount, lobbyOptions);
        //    Debug.Log("Created and joined lobby");

        //    InLobbyMenu.SetLobby(hostedLobby);
        //    InLobbyMenu.SetAsHost();

        //    ActivateNewMenu(InLobbyMenu.gameObject);
        //}

//        private static Player GetPlayer()
//        {
//            var playerName = SettingsManager.Instance.GetPlayerData().Name;

//#if UNITY_EDITOR
//            if (ClonesManager.IsClone())
//            {
//                playerName = ClonesManager.GetArgument();
//            }
//#endif

//            return new Player
//            {
//                Data = new Dictionary<string, PlayerDataObject>
//                {
//                    {
//                        "PlayerName",
//                        new PlayerDataObject(PlayerDataObject.VisibilityOptions.Member, playerName)
//                    }
//                }
//            };
//        }
    }
}
