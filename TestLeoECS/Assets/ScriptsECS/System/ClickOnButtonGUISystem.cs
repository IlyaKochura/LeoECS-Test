using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class ClickOnButtonGUISystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<SearchButtonGUIComponent> _filter = null;
        

        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var search = ref _filter.Get1(i);

                ref var buttonsUI = ref search.buttonsUI;

                for (int j = 0; j < buttonsUI.Count; j++)
                {
                    var id = j;
                    buttonsUI[j].Action = () => SendMessageInConsole(id);
                }
            }
        }

        public void Run()
        {
            
        }

        public void SendMessageInConsole(int i)
        {
            Debug.LogError($"Кнопка {i}");
        }
        
    }
}