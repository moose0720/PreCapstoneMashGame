using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject currentDot;
    public GameData GameData;
    GameObject lastEnteredDot;
    public float LoseThreshold = .5f;
    public GameEvent DotMissed;
    public GameEvent DotScored;
    public GameEvent levelCleared;

    void OnTriggerEnter2D(Collider2D other)
    {
        currentDot = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        lastEnteredDot = currentDot;
        currentDot = null;
        //Debug.Log("Last dot set");
    }

    void Update()
    {
        if (GameData.isRunning)
        {
            //Find distance b/w last dot and current pos. And if it's higher than some threshold then raise DotMissed Event
            if (lastEnteredDot && GetDistanceFromLastDot() > LoseThreshold)
            {
                DotMissed.Raise();
            }



            if (didTap)
            {
              
                if (currentDot != null)
                {
                    Destroy(currentDot);
                    GameData.DotsRemaining--;

                    if (GameData.DotsRemaining <= 0)
                    {
                        GameData.DotsRemaining = 0;
                        GameData.CurrentLevel++;
                        levelCleared.Raise();
                    }
                    else 
                    {
                        DotScored.Raise();
                    }
                }
                else
                {
                   DotMissed.Raise();
                }
                
            }   
        }


    }

    float GetDistanceFromLastDot()
    {
        //Debug.Log((transform.position - lastEnteredDot.transform.position).magnitude);
        return (transform.position - lastEnteredDot.transform.position).magnitude;
    } 


    bool didTap
    {
        get
        {
            return (Input.GetKeyUp(KeyCode.Space));
        }
    }
} 