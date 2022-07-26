using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterButton = null;
        
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                _filterButton.Get1(i).cellDepth--;
                Debug.Log(_filterButton.Get1(i).cellDepth);
            }
        }
    }
}