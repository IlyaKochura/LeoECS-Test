using Leopotam.Ecs;
using ScriptsECS.Components;

namespace ScriptsECS.System
{
    sealed class ShowViewSystem : IEcsRunSystem
    {
        private readonly EcsFilter<GUIViewComponent> _filterView;
        private readonly EcsFilter<GameManagerComponent> _filterManager;
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
        }
    }
}