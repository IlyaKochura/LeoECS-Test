using Leopotam.Ecs;
using Leopotam.Ecs.Ui.Systems;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine;
using Voody.UniLeo;

namespace ScriptsECS.System
{
    sealed class ButtonOffSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, EmptyEvent> _filterEmpty = null;
        private readonly EcsFilter<InstantiateGUISettingsComponent> _filterGameobject;

        public void Run()
        {
            foreach (var i in _filterEmpty)
            {
                
            }
        }
    }
}