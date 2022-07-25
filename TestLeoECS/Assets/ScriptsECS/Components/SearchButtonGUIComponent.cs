using System;
using System.Collections.Generic;
using ScriptsMono;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct SearchButtonGUIComponent
    {
        [HideInInspector] public List<ButtonGUIDelegate> buttonsUI;
    }
}