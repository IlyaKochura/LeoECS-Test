using System;
using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class CounterSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterButton = null;
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;

        private Action _action;
        
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                foreach (var g in _filterManager)
                {
                    _filterManager.Get1(g).shovelCounter--;
                }
            }
        }
    }
}