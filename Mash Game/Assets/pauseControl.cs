using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseControl : MonoBehaviour
{
    public float pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            time.timeScale = 0;
        }
    }
}
