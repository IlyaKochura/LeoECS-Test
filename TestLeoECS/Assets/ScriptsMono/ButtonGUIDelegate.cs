using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsMono
{
    public class ButtonGUIDelegate : MonoBehaviour
    {
        private Button _button;
        public Action action { get; set; }

        void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => action?.Invoke());
        }
    }
}