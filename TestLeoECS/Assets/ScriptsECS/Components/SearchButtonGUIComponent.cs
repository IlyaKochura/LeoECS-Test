using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct SearchButtonGUIComponent
    {
        [HideInInspector] public List<Button> buttonsUI;
    }
}