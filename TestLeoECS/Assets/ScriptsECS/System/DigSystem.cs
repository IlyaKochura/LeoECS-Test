using System.Collections.Generic;
using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;
using System;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<DigComponent, InstantiateGUISettingsComponent> _filter = null;
        
        public static int IDButtonDig;
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var settings = ref _filter.Get2(i);
                ref var dig = ref _filter.Get1(i);

                var setList = settings.buttons;
                var digCount = dig.digCount;
                
                ref var digList = ref dig.cellsDigCount;

                for (int j = 0; j < setList.Count; j++)
                {
                    digList.Add(digCount);
                }
                
            }
            
            
        }

        public void Run()
        {
            
        }

        public void Transmitter(int id)
        {
            IDButtonDig = id;
            foreach (var i in _filter)
            {
                ref var dig = ref _filter.Get1(i);
                ref var digList = ref dig.cellsDigCount;
                
                Digger(IDButtonDig,ref digList);
            }
        }

        public void Digger(int id,ref List<int> list)
        {
            list[id] -= 1;
            Debug.Log(list[id]);
        }
    }
}