using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class DigSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterButton = null;

        public void Init()
        {
            
            
        }

        public void Run()
        {


        }
    }
}