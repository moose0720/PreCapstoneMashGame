using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class counterToMash : MonoBehaviour
{
    public int mashScore;
    public TMP_Text mashText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Shows the text of Mash on screen
        mashText.text = $"Mash: {mashScore.ToString()}";
        // When the latter Z is press it will add one to mashScore. updat it to get the letter form randoMash to do the same
        if (Input.GetKeyDown(KeyCode.Z))
        {
            addMashScore();
        }

    }

    void addMashScore()
    {
        mashScore++;

        
    }

}
