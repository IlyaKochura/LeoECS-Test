using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScriptsMono.DragNDrop
{
    public class DragNDropGold : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        private RectTransform _rectTransform;
        private void Start()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.LogError("1");
        }
        
        public void OnDrag(PointerEventData eventData)
        {
            Debug.LogError("2");
            _rectTransform.anchoredPosition += eventData.delta;
        }
        
        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.LogError("3");
        }
        
        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.LogError("4");
        }
    }
}