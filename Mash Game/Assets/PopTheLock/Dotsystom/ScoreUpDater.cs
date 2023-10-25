using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpDater : MonoBehaviour
{
    public int remainingDots = 10;

    TMPro.TextMeshPro Text;

    public void decrementDots()
    {
        remainingDots--;
        if(remainingDots < 0)
        {
            remainingDots = 0;
        }
    }
    void Start()
    {
        Text = GetComponent<TMPro.TextMeshPro>();
    }

    void Update()
    {
        Text.text = remainingDots.ToString();
    }
}
