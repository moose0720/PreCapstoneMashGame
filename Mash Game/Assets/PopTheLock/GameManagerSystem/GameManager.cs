using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    public GameEvent levelCleared;
    bool isFirstTap = true;

    void Start()
    {
        GameData.resetLevel();
    }

    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space) && !GameData.isRunning && isFirstTap)
        {
            GameData.isRunning = true;
            isFirstTap = false;
        }
    }

    public void loadLevel()
    {

        GameData.resetLevel();
        isFirstTap = true;
    }
} 
