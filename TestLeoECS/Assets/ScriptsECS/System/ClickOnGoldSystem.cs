using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using UnityEngine.PlayerLoop;

namespace ScriptsECS.System
{
    public class ClickOnGoldSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClearEvent> _filterButton = null;
        
        public void Run()
        {
            foreach (var i in _filterButton)
            {
                if (_filterButton.Get1(i).itIsGold)
                {
                    _filterButton.Get1(i).itIsGold = false;
                }
            }
        }
    }
}