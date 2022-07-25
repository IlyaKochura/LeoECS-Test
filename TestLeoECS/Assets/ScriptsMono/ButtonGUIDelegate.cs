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
        [HideInInspector] public bool itIsGold;

        void Start()
        {
            itIsGold = false;
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => Action?.Invoke());
        }

        public void SetText(string text)
        {
            gameObject.GetComponentInChildren<TextMeshProUGUI>().text = text;
        }
    }
}