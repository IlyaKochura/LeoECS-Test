using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct DigComponent
    {
        [HideInInspector] public List<int> cellsDigCount;
        public int digCount;
    }
}