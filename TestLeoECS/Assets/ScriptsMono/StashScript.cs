using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScriptsMono
{
    public class StashScript : MonoBehaviour, IDropHandler
    {
        public Action Action;
        
        public void OnDrop(PointerEventData eventData)
        {
            if (eventData.pointerDrag != null)
            {
                Action.Invoke();
            }
        }
    }
}