using System;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct GameManagerComponent
    {
        public int goldToWin;
        [HideInInspector] public int goldCollector;
        public int shovelCounter;
        public bool game;
        public int cellDepth;
        [Range(1,10)]
        public int chanceGold;
    }
}