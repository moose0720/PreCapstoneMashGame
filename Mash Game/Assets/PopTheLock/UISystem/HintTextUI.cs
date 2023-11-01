using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintTextUI : MonoBehaviour
{
    public GameData GameData;
    // Start is called before the first frame update
    void start()
    {
       if(GameData.CurrentLevel != 1)
        {
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        if (GameData.CurrentLevel != 1)
        {
            gameObject.SetActive(false);
        }
    }
} 
