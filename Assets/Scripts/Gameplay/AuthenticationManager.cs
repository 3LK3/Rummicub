using ParrelSync;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

namespace Rummicub
{
    public class AuthenticationManager : MonoBehaviour
    {
        public static AuthenticationManager Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                GameObject.Destroy(Instance.gameObject);
            }

            Instance = this;
            DontDestroyOnLoad(this);
        }

        private async void Start()
        {
            await UnityServices.InitializeAsync();
        }

        public async void SignInAnonymously()
        {
#if UNITY_EDITOR
            if (ClonesManager.IsClone())
            {
                var cloneName = ClonesManager.GetArgument();
                Debug.Log("This is a clone named: " + cloneName);
                Debug.Log("Switching to profile " + cloneName);

                AuthenticationService.Instance.SwitchProfile(cloneName);
            }
#endif

            await AuthenticationService.Instance.SignInAnonymouslyAsync();
        }
    }
}
