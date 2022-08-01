using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class ClearCellsSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClearEvent> _filterButton = null;
        private readonly EcsFilter<ButtonComponent> _filterFinal = null;
        
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                _filterButton.Get1(i).text.text = "";
            }

            foreach (var i in _filterFinal)
            {
                if (_filterFinal.Get1(i).button.GetComponent<Button>().interactable == false)
                {
                    _filterFinal.Get1(i).text.text = "";
                }
            }
        }
    }
}