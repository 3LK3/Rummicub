using UnityEngine;

namespace Rummicub.Gameplay
{
    public class GamePreferences : MonoBehaviour
    {
        public static GamePreferences Instance;

        public int MaximumPlayerCount;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                GameObject.Destroy(Instance.gameObject);
            }

            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
}
