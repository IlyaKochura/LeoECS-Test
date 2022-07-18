using System.Collections.Generic;
using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;
using UnityEngine.UI;
using ScriptsMono;

namespace ScriptsECS.System
{
    sealed class InstantiateGUIButtonSystem : IEcsPreInitSystem, IEcsInitSystem
    {
        private readonly EcsFilter<InstantiateGUISettingsComponent, SearchButtonGUIComponent> _filter = null; 
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var component = ref _filter.Get1(i);
                ref var search = ref _filter.Get2(i);
                
                ref var objectslist = ref component.buttons;
                ref var buttonsList = ref search.buttonsUI;

                buttonsList = new List<ButtonGUIDelegate>(objectslist.Count);
                
                for (int j = 0; j < objectslist.Count; j++)
                {
                    var id = j;
                    buttonsList.Add(objectslist[i].GetComponent<ButtonGUIDelegate>());
                }

            }
        }

        public void PreInit()
        {
            foreach (var i in _filter)
            {
                ref var component = ref _filter.Get1(i);

                var prefab = component.spawnPrefab;
                var point = component.spawnPoint;
                var length = component.sideLength;
                var width = component.sideWidth;
                
                ref var gridConst = ref component.grid;
                ref var objects = ref component.buttons;
                
                gridConst.constraintCount = length;
                
                objects = new List<GameObject>(length * width);
                
                for (int j = 0; j < length * width; j++)
                {
                    var slot = Object.Instantiate(prefab, point);
                    
                    objects.Add(slot);
                }
            }
        }
    }
}