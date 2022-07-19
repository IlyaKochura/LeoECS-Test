using System;
using System.Collections.Generic;
using ScriptsMono;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct SearchButtonGUIComponent
    {
        [HideInInspector] public List<ButtonGUIDelegate> buttonsUI;
        public ButtonGUIDelegate button;
    }
}