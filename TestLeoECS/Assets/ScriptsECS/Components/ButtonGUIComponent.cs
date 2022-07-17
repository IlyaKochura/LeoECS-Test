using System;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct ButtonGUIComponent
    {
        public int ID;
        [HideInInspector] public bool itIsGold;
        
    }
}