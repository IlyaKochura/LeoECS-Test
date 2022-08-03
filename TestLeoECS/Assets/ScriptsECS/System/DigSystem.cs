using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterButton = null;
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;

        public void Run()
        {
            foreach (var g in _filterManager)
            {
                if (_filterManager.Get1(g).game)
                {
                    foreach (var i in _filterButton)
                    {
                        if (_filterButton.Get1(i).itIsGold == false)
                        {
                            _filterButton.Get1(i).cellDepth--;
                            _filterButton.GetEntity(i).Get<DigEvent>();
                        }
                    }
                }
            }
        }
    }
}