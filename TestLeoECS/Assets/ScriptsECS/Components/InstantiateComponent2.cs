using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct InstantiateComponent2
    {
        public Transform spawnPoint;
        public GameObject spawnPrefab;
        public int sideLength;
        public int sideWidth;
        public GridLayoutGroup grid;
        [HideInInspector] public List<GameObject> buttons;
    }
}