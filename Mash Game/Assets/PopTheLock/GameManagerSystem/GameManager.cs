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

    public void decrementRemainingDots()
    {
        GameData.DotsRemaining--;

        if (GameData.DotsRemaining <= 0)
        {
            GameData.DotsRemaining = 0;
            levelCleared.Raise();
        }
    }
    public void loadLevel(bool next)
    {
        if (next)
        {
            GameData.CurrentLevel++;
        }
        GameData.resetLevel();
        isFirstTap = true;
    }
 

    public void stopGame()
    {
        GameData.isRunning = false;
    }
} 
