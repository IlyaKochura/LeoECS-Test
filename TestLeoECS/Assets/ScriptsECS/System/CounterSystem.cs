using System;
using System.Runtime.CompilerServices;
using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine.UIElements;
using ClickEvent = ScriptsECS.Events.ClickEvent;

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
                _filterManager.Get1(0).shovelCounter--;
            }
        }
    }
}