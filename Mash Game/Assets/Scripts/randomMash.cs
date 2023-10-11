using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomMash : MonoBehaviour
{
    public TMP_Text largeText;
    public KeyCode Win;

    public string currentLetter = "";
    public string[] letter = new string[] { "Z", "Q", "J", "X" };

    public void randomLetter()
    {
        currentLetter = letter[Random.Range(0, letter.Length)];
        largeText.text = currentLetter;
        Debug.Log("RANDOM LETTER: " + currentLetter);
    }

    // Update is called once per frame

    void Start()
    {
        //pickRandomMashLetter();
    }
        
    
    // This will randomly pick the letter Z,Q,J. Update it to slow down for the player can see the letter.
    public void pickRandomMashLetter()
    {
        //string[] letter = new string[] { "Z", "Q", "J", "X"};
        //string randomletter = letter[Random.Range(0, letter.Length)];
        randomLetter();
        
       
        switch (currentLetter)
        {
            case "Z":
                Win = KeyCode.Z;
                break;
                
            case "Q":
                Win= KeyCode.Q;
                break;
            case "J":
                Win = KeyCode.J;
                break;
           case "X":
                Win = KeyCode.X;
                break; 

        }

        currentLetter = "";
        
    }

}
