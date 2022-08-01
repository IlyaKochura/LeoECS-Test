using System;
using TMPro;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct ButtonComponent
    {
        public int cellDepth;
        [HideInInspector] public bool itIsGold;
        public TextMeshProUGUI text;
        public GameObject button;
        
    }
}