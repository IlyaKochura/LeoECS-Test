using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterButton = null;

        public void Run()
        {
            foreach (var i in _filterButton)
            {
                if (_filterButton.Get1(i).itIsGold == false)
                {
                    _filterButton.Get1(i).cellDepth--;
                    _filterButton.GetEntity(i).Get<DigEvent>();
                }
                else
                {
                    _filterButton.GetEntity(i).Get<ClearEvent>();
                }
            }
        }
    }
}