using System;
using Leopotam.Ecs;
using ScriptsECS.Events;
using ScriptsECS.Components;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ScriptsECS.System
{
    sealed class SetGoldSystem : IEcsRunSystem
    {
        private EcsFilter<ButtonComponent, GoldEvent> _filterGold = null;
        private EcsFilter<DragNDropManagerComponent> _filterDragnDrop = null;
        public void Run()
        {
            foreach (var managerID in _filterDragnDrop)
            {
                foreach (var goldButtonId in _filterGold)
                {
                    Object.Instantiate(_filterDragnDrop.Get1(managerID).prefabGold,
                        _filterGold.Get1(goldButtonId).button.transform.position, 
                        Quaternion.identity,
                        _filterDragnDrop.Get1(managerID).canvasParent.transform);
                }
            }
        }
    }
}