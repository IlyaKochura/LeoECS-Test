using System.Collections.Generic;
using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class InsantiateGUIButtonSystem : IEcsInitSystem
    {
        private readonly EcsFilter<InstantiateGUISettingsComponent> _filter = null; 
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var component = ref _filter.Get1(i);

                var prefab = component.spawnPrefab;
                var point = component.spawnPoint;
                var length = component.sideLength;
                var width = component.sideWidth;
                ref var gridConst = ref component.grid;
                ref var buttons = ref component.buttons;

                gridConst.constraintCount = length;

                buttons = new List<GameObject>(length * width);
                for (int j = 0; j < length * width; j++)
                {
                    var slot = Object.Instantiate(prefab, point);
                    buttons.Add(slot);
                } 

            }
            
        }
        
        
    }
}