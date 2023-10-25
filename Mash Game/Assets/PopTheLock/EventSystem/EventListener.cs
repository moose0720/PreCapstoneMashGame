using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    void OnEnable()
    {
        Event.Register(this);
    }

    void OnDisable()
    {
        Event.DeRegister(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
} 
