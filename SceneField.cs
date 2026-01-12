using System;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
    public class SceneField
    {
        [SerializeField] private Object sceneAsset;
        [SerializeField] private string sceneName = "";
    
        public string Name => sceneName;
    }