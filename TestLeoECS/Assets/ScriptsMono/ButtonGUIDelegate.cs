using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptsMono
{
    public class ButtonGUIDelegate : MonoBehaviour
    {
        private Button _button;
        public Action Action { get; set; }

        void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => Action?.Invoke());
        }
    }
}