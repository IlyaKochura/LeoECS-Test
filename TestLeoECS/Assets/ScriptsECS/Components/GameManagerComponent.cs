using System;

namespace ScriptsECS.Components
{
    [Serializable]
    public struct GameManagerComponent 
    {
        public int shovelCount;
        public int goldToWin;
        public int goldCollector;
        public int shovelCounter;
        public bool game;
        public int cellDepth;
    }
}