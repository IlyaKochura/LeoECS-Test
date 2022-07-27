using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class ButtonOffSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, EmptyEvent> _filterEmpty = null;

        public void Run()
        {
            foreach (var i in _filterEmpty)
            {
                _filterEmpty.GetEntity(i).Destroy();
            }
        }
    }
}