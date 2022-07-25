using System;
using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class ClickOnButtonGUISystem : IEcsInitSystem
    {
        private readonly EcsFilter<SearchButtonGUIComponent> _filter = null;
        private EcsFilter<ButtonComponent> _filterButton = null;
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var search = ref _filter.Get1(i);

                ref var buttonsUI = ref search.buttonsUI;

                for (int j = 0; j < buttonsUI.Count; j++)
                {
                    var id = j;
                    buttonsUI[j].Action = () => SendEvent(id);
                }
            }
            
        }

        private void SendEvent(int id)
        {
            ref var entity = ref _filterButton.GetEntity(id);
            entity.Get<ClickEvent>();
        }
        
        
    }
}