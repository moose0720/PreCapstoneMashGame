using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoker : MonoBehaviour
{

    public GameEvent loadLevel;

    public void raiseLoadGame()
    {
        loadLevel.Raise();


    }
} 