using Leopotam.Ecs;
using ScriptsECS.Components;

namespace ScriptsECS.System
{
    sealed class WinOrFailCheckSystem : IEcsRunSystem
    {
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;

        public void Run()
        {
            foreach (var i in _filterManager)
            {
                if (_filterManager.Get1(i).shovelCounter <= 0 || _filterManager.Get1(i).goldCollector == _filterManager.Get1(i).goldToWin)
                {
                    _filterManager.Get1(i).game = false;
                }
            }
        }
    }
}