using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;

namespace ScriptsECS.System
{
    public class DroppedSystem : IEcsRunSystem
    {
        private readonly EcsFilter<StashComponent> _filterStash = null;
        
        public void Run()
        {
            foreach (var stashId in _filterStash)
            {
                _filterStash.Get1(stashId).stash.Action = () => _filterStash.GetEntity(stashId).Get<DroppedEvent>();
            }
        }        
    }
}