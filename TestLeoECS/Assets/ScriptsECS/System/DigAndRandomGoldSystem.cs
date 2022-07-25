using Leopotam.Ecs;
using ScriptsECS.Components;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ScriptsECS.System
{
    sealed class DigAndRandomGoldSystem : IEcsInitSystem, IEcsRunSystem
    {
        private readonly EcsFilter<DigComponent> _filter = null;
        private readonly EcsFilter<InstantiateGUISettingsComponent> _filterButton = null;
        private readonly EcsFilter<SearchButtonGUIComponent> _filterSearch = null;
        private readonly EcsFilter<GUIViewComponent> _filterView = null;

        private int _goldCollector;
        private int _shovelCounter;
        private bool _game;

        private ClickOnButtonGUISystem _sys;
        public DigAndRandomGoldSystem(ClickOnButtonGUISystem click)
        {
            _sys = click;
        }
        
        public void Init()
        {
            _game = true;
            _shovelCounter = _filterButton.Get1(0).shovelCount;
            _sys.Action += Digger;
            _sys.RestartAction += RestartGame;
        }

        public void Run()
        {
            if (_goldCollector >= _filterButton.Get1(0).goldToWin)
            {
                _game = false;
                _filterView.Get1(0).winTitle.SetActive(true);
            }
            ViewCounters();
        }

        private void Digger(int id)
        {
            if (_game)
            {
                if(_shovelCounter <= 0) return;

                if (!_filterSearch.Get1(0).buttonsUI[id].itIsGold)
                {
                    Dig(id);
                }
                else
                {
                    CleanCells(id);
                }

                
                if (_filter.Get1(0).cellsDigCount[id] == 0)
                {
                    _filterButton.Get1(0).buttons[id].GetComponent<Button>().interactable = false;
                }

                if (_shovelCounter <= 0)
                {
                    CleanField();
                }
            }
        }

        private void RandomGold(int id)
        {
            var rnd = Random.Range(0, 6);

            if (rnd >= 2)
            {
                _filterSearch.Get1(0).buttonsUI[id].itIsGold = true;
                _filterSearch.Get1(0).buttonsUI[id].SetText("Голда");
            }
        }

        private void CleanCells(int id)
        {
            if(_filterSearch.Get1(0).buttonsUI[id].itIsGold)
            {
                _filterSearch.Get1(0).buttonsUI[id].itIsGold = false;
                _filterSearch.Get1(0).buttonsUI[id].SetText("");
                _goldCollector++;
            }
        }
        
        private void ViewCounters()
        {
            _filterView.Get1(0).textGold.text = $"Gold {_goldCollector}";
            _filterView.Get1(0).textShovel.text = $"Shovel {_shovelCounter}";
        }

        private void Dig(int id)
        {
            if (!_filterSearch.Get1(0).buttonsUI[id].itIsGold && _shovelCounter > 0) 
            {
                _filter.Get1(0).cellsDigCount[id] -= 1;
                _shovelCounter--;
                if (_filter.Get1(0).cellsDigCount[id] != 0 && !_filterSearch.Get1(0).buttonsUI[id].itIsGold)
                {
                    RandomGold(id);
                }
            }
        }

        private void CleanField()
        {
            for (int i = 0; i < _filterSearch.Get1(0).buttonsUI.Count ; i++)
            {
                _filterSearch.Get1(0).buttonsUI[i].itIsGold = false;
                _filterSearch.Get1(0).buttonsUI[i].SetText("");
            }
        }
        
        private void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }
}