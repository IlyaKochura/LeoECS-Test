using Leopotam.Ecs;
using Leopotam.Ecs.Ui.Systems;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine;
using UnityEngine.UI;
using Voody.UniLeo;

namespace ScriptsECS.System
{
    sealed class ButtonOffSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, EmptyEvent> _filterEmpty = null;
        
        public void Run()
        {
            foreach (var i in _filterEmpty)
            {
                _filterEmpty.Get1(i).button.GetComponent<Button>().interactable = false;
            }
        }
    }
}