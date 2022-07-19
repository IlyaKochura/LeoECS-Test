using System;
using Leopotam.Ecs;
using ScriptsECS.Components;

namespace ScriptsECS.System
{
    sealed class ClickOnButtonGUISystem : IEcsInitSystem
    {
        private readonly EcsFilter<SearchButtonGUIComponent> _filter = null;
        public event Action<int> Action;
        public event Action RestartAction;
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var search = ref _filter.Get1(i);

                ref var buttonsUI = ref search.buttonsUI;

                for (int j = 0; j < buttonsUI.Count; j++)
                {
                    var id = j;
                    buttonsUI[j].Action = () =>  Action?.Invoke(id);
                }
            }

            _filter.Get1(0).button.Action = () => RestartAction?.Invoke();
        }
    }
}