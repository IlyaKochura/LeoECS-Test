using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct InstantiateGUISettingsComponent
    {
        public Transform spawnPoint;
        public GameObject spawnPrefab;
        public int sideLength;
        public int sideWidth;
        public GridLayoutGroup grid;
        public int shovelCount;
        [HideInInspector] public List<GameObject> buttons;
    }
}