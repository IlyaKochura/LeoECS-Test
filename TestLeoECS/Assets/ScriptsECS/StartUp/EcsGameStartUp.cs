using UnityEngine;
using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsECS.Events;
using ScriptsECS.System;
using Voody.UniLeo;

namespace ScriptsECS.StartUp
{
    public class EcsGameStartUp : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;

        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            _systems.ConvertScene();
            AddInjections();
            AddSystems();
            AddOneFrames();
            _systems.Init();
        }

        private void Update()
        {
            _systems.Run();
        }

        private void AddInjections()
        { 
            
        }
        
        private void AddSystems()
        {
            _systems.Add(new InstantiateGUIButtonSystem()).
                     Add(new ClickOnButtonGUISystem()).
                     Add(new DigSystem()).
                     Add(new GameRestartSystem()).
                     Add(new CounterSystem()).
                     Add(new ShowViewSystem()).
                     Add(new EmptyCellsSystem()).
                     Add(new ButtonOffSystem()).
                     Add(new RandomGoldSystem()).
                     Add(new ClickOnGoldSystem()).
                     Add(new ClearCellsSystem()).
                     Add(new SetGoldSystem());
        }

        private void AddOneFrames()
        {
            _systems.OneFrame<ClickEvent>().
                     OneFrame<EmptyEvent>().
                     OneFrame<ClearEvent>().
                     OneFrame<DigEvent>().
                     OneFrame<GoldEvent>();
                        
        }

        private void OnDestroy()
        {
            if(_systems == null) return;
            
            _systems.Destroy();
            _systems = null;
            _world.Destroy();
            _world = null;
            
        }
    }
}