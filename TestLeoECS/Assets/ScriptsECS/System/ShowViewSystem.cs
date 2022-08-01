using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class ShowViewSystem : IEcsRunSystem
    {
        private readonly EcsFilter<GUIViewComponent> _filterView;
        private readonly EcsFilter<GameManagerComponent> _filterManager;
        private readonly EcsFilter<GameManagerComponent, WinEvent> _filterManagerWin;
        public void Run()
        {
            foreach (var g in _filterView)
            {
                foreach (var i in _filterManager)
                {
                    _filterView.Get1(g).textShovel.text = $"Shovel {_filterManager.Get1(i).shovelCounter}";
                    _filterView.Get1(g).textGold.text = $"Gold {_filterManager.Get1(i).goldCollector}";
                }
            }
            
            foreach (var i in _filterManagerWin)
            {
                _filterView.Get1(0).winTitle.SetActive(true);
            }
        }
    }
}