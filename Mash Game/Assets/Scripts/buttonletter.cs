using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonletter : MonoBehaviour
{
    public TMP_Text smallText;
   // public KeyCode Win;
    // Update is called once per frame

    void Start()
    {
        buttonletters();
    }


    // This will randomly pick the letter Z,Q,J. Update it to slow down for the player can see the letter.
    public void buttonletters()
    {
        string[] letter = new string[] { "Z", "Q", "J", "X" };
        string randomletter = letter[Random.Range(0, letter.Length)];
       smallText.text = randomletter;

       /* switch (randomletter)
        {
            case "Z":
                Win = KeyCode.Z;
                break;

            case "Q":
                Win = KeyCode.Q;
                break;
            case "J":
                Win = KeyCode.J;
                break;
            case "X":
                Win = KeyCode.X;
                break;

        } */

    } 

}
