using System.Collections.Generic;
using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Providers;
using UnityEngine;
using ScriptsMono;

namespace ScriptsECS.System
{
    sealed class InstantiateGUIButtonSystem : IEcsInitSystem
    {
        private readonly EcsFilter<InstantiateGUISettingsComponent, SearchButtonGUIComponent> _filter = null; 
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;
        private readonly EcsFilter<ButtonComponent> _filterButton = null;
        
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var component = ref _filter.Get1(i);
                ref var search = ref _filter.Get2(i);

                var prefab = component.spawnPrefab;
                var point = component.spawnPoint;
                var length = component.sideLength;
                var width = component.sideWidth;
                
                ref var gridConst = ref component.grid;
                ref var objects = ref component.buttons;
                ref var buttonsList = ref search.buttonsUI;
                
                gridConst.constraintCount = length;
                
                objects = new List<GameObject>(length * width);
                buttonsList = new List<ButtonGUIDelegate>(objects.Count);
                
                for (int j = 0; j < length * width; j++)
                {
                    var slot = Object.Instantiate(prefab, point);
                    objects.Add(slot);
                    buttonsList.Add(objects[j].GetComponent<ButtonGUIDelegate>());
                }
            }
            
            
        }
        
    }
}