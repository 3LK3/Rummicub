using System;
using Unity.Netcode;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rummicub.SceneManagement
{
    [Serializable]
    public class SceneStateAsset
    {
        public SceneState State;
        public SceneAsset SceneAsset;
    }

    public class SceneTransitionHandler : NetworkBehaviour
    {
        public SceneStateAsset[] SceneStateAssets;

        [HideInInspector]
        public static SceneTransitionHandler Instance { get; private set; }

        private SceneState m_sceneState;


        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                GameObject.Destroy(Instance.gameObject);
            }

            Instance = this;
            DontDestroyOnLoad(this);

            SetSceneState(SceneState.Init);
        }

        private void Start()
        {
            if (m_sceneState == SceneState.Init)
            {
                SceneManager.LoadSceneAsync(GetSceneName(SceneState.StartMenu));
            }
        }

        public void SwitchScene(SceneState state)
        {
            var sceneName = GetSceneName(state);
            //if (NetworkManager.Singleton.IsListening)
            //{
            //    Debug.Log("NetworkManager is listening");

            //    NetworkManager.Singleton.SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            //}
            //else
            //{
            //    Debug.Log("NetworkManager is NOT listening");

                SceneManager.LoadSceneAsync(sceneName);
            //}
        }

        private void SetSceneState(SceneState state)
        {
            m_sceneState = state;
        }

        private string GetSceneName(SceneState state)
        {
            foreach (var asset in SceneStateAssets)
            {
                if (asset.State == state)
                {
                    return asset.SceneAsset.name;
                }
            }
            return state.ToString();
        }
    }
}

