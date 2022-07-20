using System;
using TMPro;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct GUIViewComponent
    {
        public TextMeshProUGUI textGold;
        public TextMeshProUGUI textShovel;
        public GameObject winTitle;
    }
}