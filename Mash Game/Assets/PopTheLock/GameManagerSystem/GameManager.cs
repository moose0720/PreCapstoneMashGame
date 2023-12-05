using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    bool isFirstTap = true;

    void Start()
    {
        GameData.ResetLevel();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameData.isRunning && isFirstTap)
        {
            GameData.isRunning = true;
            isFirstTap = false;
        }
    }

    public void LoadLevel()
    {
        GameData.ResetLevel();
        isFirstTap = true;
    }


}
