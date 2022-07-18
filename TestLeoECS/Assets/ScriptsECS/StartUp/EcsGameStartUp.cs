using UnityEngine;
using Leopotam.Ecs;
using ScriptsECS.System;
using Voody.UniLeo;

namespace LeoECS
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
                Add(new ClickOnButtonGUISystem()).Add(new DigSystem());
        }

        private void AddOneFrames()
        {
            
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