using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public GameEvent[] Events;
    public UnityEvent Response;

    void OnEnable()
    {
       foreach(GameEvent ev in Events)
        {
            ev.Register(this);
        }
    }

    void OnDisable()
    {
        foreach (GameEvent ev in Events)
        {
            ev.Register(this);
        }
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
} 
