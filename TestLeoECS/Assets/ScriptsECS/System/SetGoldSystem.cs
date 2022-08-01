using Leopotam.Ecs;
using ScriptsECS.Components;

namespace ScriptsECS.System
{
    sealed class SetGoldSystem : IEcsRunSystem
    {
        private EcsFilter<ButtonComponent, GoldEvent> _filterGold = null;

        public void Run()
        {
            foreach (var i in _filterGold)
            {
                _filterGold.Get1(i).text.text = "голда";
            }
        }
    }
}