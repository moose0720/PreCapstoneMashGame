using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoker : MonoBehaviour
{
    public GameEvent[] events;
    

    public void Raise(int index)
    {
        events[indexer].Raise();
    }

} 