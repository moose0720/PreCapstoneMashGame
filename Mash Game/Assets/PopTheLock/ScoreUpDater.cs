using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpDater : MonoBehaviour
{
    public int RemainingDots = 5;

    TMPro.TextMeshPro text;

    public void DecrementDots()
    {
        RemainingDots--;
        if (RemainingDots < 0)
        {
            RemainingDots = 0;
        }


    }
    
    void Start()
    {
        text = GetComponent<TMPro.TextMeshPro>();
    }
    
    void update()
    {
        text.text = RemainingDots.ToString();
    }
}
