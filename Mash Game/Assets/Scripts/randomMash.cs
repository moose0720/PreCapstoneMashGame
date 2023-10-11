using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomMash : MonoBehaviour
{
    public TMP_Text largeText;
    public KeyCode Win;
    // It will start a nothing but then it will pick a letter from Z, Q, J, X
    public string currentLetter = "";
    public string[] letter = new string[] { "Z", "Q", "J", "X" };

    public void randomLetter()
    {
        // This is the picking the letter from the letter that on screen then to the next once the player mash the latter
        currentLetter = letter[Random.Range(0, letter.Length)];
        largeText.text = currentLetter;
        //This is showing what letter is being called regarles if it on screen or not
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
        // The currentLetter is will start as nothing befor it to be pick of a random letter
        currentLetter = "";
        
    }

}
