using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct InstantiateComponent
    {
        public Transform spawnPoint;
        public GameObject spawnPrefab;
        public int sideLength;
        public int sideWidth;
        public List<GameObject> buttons;
    }
}