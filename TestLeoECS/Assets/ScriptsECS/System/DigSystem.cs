using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<DigComponent, InstantiateGUISettingsComponent> _filter = null;

        private ClickOnButtonGUISystem _click = new ClickOnButtonGUISystem();
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

        private void Digger(int id)
        {
            Debug.LogError(id);
        }
    }
}