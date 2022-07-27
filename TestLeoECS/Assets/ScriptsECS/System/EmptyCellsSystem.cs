using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class EmptyCellsSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent> _filterButton = null;

        public void Run()
        {
            CheckEmptyOrNot();
        }

        void CheckEmptyOrNot()
        {
            foreach (var i in _filterButton)
            {
                if (_filterButton.Get1(i).cellDepth <= 0)
                {
                    _filterButton.GetEntity(i).Get<EmptyEvent>();
                }
            }
        }
    }
}