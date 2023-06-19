using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Vector2 EventDataDelta
    {
        get;
        private set;
    }

    public void OnDrag(PointerEventData eventData)
    {
        EventDataDelta = eventData.delta;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        EventDataDelta = Vector2.zero;
    }
}
