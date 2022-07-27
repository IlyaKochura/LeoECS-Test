using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class ToAppointSystem : IEcsRunSystem, IEcsInitSystem
    {
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;
        private EcsFilter<ButtonComponent> _filterButton = null;

        public void Init()
        {
            Debug.LogError($"InitCount {_filterButton.GetEntitiesCount()}");
        }
        
        public void Run()
        {
            Debug.LogError(_filterButton.GetEntitiesCount());
        }
    }
}