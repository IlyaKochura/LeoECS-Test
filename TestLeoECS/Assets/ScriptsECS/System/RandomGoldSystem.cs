using System;
using Leopotam.Ecs;
using UnityEngine;
using ScriptsECS.Components;
using ScriptsECS.Events;
using Random = System.Random;

namespace ScriptsECS.System
{
    sealed class RandomGoldSystem : IEcsRunSystem
    {
        private readonly EcsFilter<ButtonComponent, ClickEvent> _filterClick = null;
        private readonly EcsFilter<GameManagerComponent> _filterManager = null;
        
        public void Run()
        {
            Random rnd = new Random();
            foreach (var j in _filterManager)
            {
                foreach (var i in _filterClick)
                {
                    var gold = rnd.Next(0, 10);
                    if (gold > _filterManager.Get1(j).chanceGold)
                    {
                        _filterClick.Get1(i).itIsGold = true;
                        _filterClick.GetEntity(i).Get<GoldEvent>();
                    }
                }
            }
        }
    }
}