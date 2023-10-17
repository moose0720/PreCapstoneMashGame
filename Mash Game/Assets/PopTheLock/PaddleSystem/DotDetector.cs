using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject currentDot;
    bool isRunning = false;

    // Check if the dot and the bar is colliding 
    void OnTriggerEnter2D(Collider2D other)
    {
        currentDot = other.gameObject;
    }
    // Check if the bar has moved away for the dot that previously collided with
    void OnTriggerExit2D(Collider2D other)
    {
        currentDot = null;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(!isRunning)
            {
                isRunning = true;
                return;
            }
            if (currentDot != null)
            {
                Destroy(currentDot);
                Debug.Log("Score += MashScore");
            }
            else
            {
                Debug.Log("Score -= MashScore && backto mashawayGame");
            }
        }
    }
}
