using System.Collections.Generic;
using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<DigComponent> _filter = null;

        private ClickOnButtonGUISystem _sys;
        public DigSystem(ClickOnButtonGUISystem click)
        {
            _sys = click;
        }
        
        public void Init()
        {
            _sys.Action += Digger;
        }

        public void Run()
        {
            
        }

        private void Digger(int id)
        {
            if (_filter.Get1(0).cellsDigCount[id] != 0)
            {
                Debug.LogError(id);
                Debug.LogError(_filter.Get1(0).cellsDigCount.Count);
                _filter.Get1(0).cellsDigCount[id] -= 1;
                Debug.LogError($"Вырыл {_filter.Get1(0).cellsDigCount[id]}");
            }
        }
    }
}