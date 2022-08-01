using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct ButtonComponent
    {
        public int cellDepth;
        [HideInInspector] public bool itIsGold;
        [HideInInspector] public TextMeshProUGUI text;
        public GameObject button;
        
    }
}