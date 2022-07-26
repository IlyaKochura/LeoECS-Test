using Leopotam.Ecs;
using ScriptsECS.Components;
using ScriptsMono;
using UnityEngine.SceneManagement;

namespace ScriptsECS.System
{
    sealed class GameRestartSystem : IEcsInitSystem
    {
        private readonly EcsFilter<GUIViewComponent> _filter = null;

        public void Init()
        {
            foreach (var i in _filter)
            {
                _filter.Get1(i).buttonRestart.GetComponent<ButtonGUIDelegate>().Action = () => Restart();
            }
        }

        private void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }
}