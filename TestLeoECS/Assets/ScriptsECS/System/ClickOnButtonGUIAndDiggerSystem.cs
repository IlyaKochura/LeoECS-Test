using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class ClickOnButtonGUIAndDiggerSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<SearchButtonGUIComponent, DigComponent> _filter = null;
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var settings = ref _filter.Get1(i);
                ref var dig = ref _filter.Get2(i);

                var setList = settings.buttonsUI;
                var digCount = dig.digCount;
                
                ref var digList = ref dig.cellsDigCount;

                for (int j = 0; j < setList.Count; j++)
                {
                    digList.Add(digCount);
                }
                
                
                ref var search = ref _filter.Get1(i);
                ref var buttonsUI = ref search.buttonsUI;

                for (int j = 0; j < buttonsUI.Count; j++)
                {
                    var id = j;
                    buttonsUI[j].Action = () => SendIdToDigSystem(id);
                }
            }
        }

        public void Run()
        {
            
        }

        public void SendIdToDigSystem(int id)
        {
            Debug.LogError(id);
            foreach (var x in _filter)
            {
                ref var dig = ref _filter.Get2(x);
                ref var digList = ref dig.cellsDigCount;
                
                digList[id] -= 1;
                Debug.LogError(digList[id]);
            }
        }
        
    }
}