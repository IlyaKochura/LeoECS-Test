using System;
using System.Data;
using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    sealed class CounterSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, DigEvent> _filterButton = null;
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;
        private readonly EcsFilter<StashComponent, DroppedEvent> _filterStash = null;
        
        
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                foreach (var g in _filterManager)
                {
                    _filterManager.Get1(g).shovelCounter--;
                }
            }
            
            foreach (var i in _filterStash)
            {
                foreach (var g in _filterManager)
                {
                    _filterManager.Get1(g).goldCollector++;
                }
                
            }
        }
    }
    
}