using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class ClearCellsSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClearEvent> _filterButton = null;
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                _filterButton.Get1(i).text.text = "";
            }
        }
    }
}