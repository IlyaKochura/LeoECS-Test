using System;
using UnityEngine;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct GameManagerComponent
    {
        // [HideInInspector] public int currentShovelCount;
        // [HideInInspector] public int cu
        // public int shovels;
        public int goldToWin;
        public int goldCollector;
        public int shovelCounter;
        public bool game;
        public int cellDepth;
    }
}