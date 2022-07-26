using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class ToAppointSystem : IEcsInitSystem
    {
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;
        private readonly EcsFilter<ButtonComponent> _filterButton = null;
        
        public void Init()
        {
            foreach (var i in _filterManager)
            {
                foreach (var g in _filterButton)
                {
                    _filterButton.Get1(g).cellDepth = _filterManager.Get1(i).cellDepth;
                }
            }
        }
    }
}