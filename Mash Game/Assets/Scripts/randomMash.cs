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
    public string[] letter = new string[] { "Z", "Q", "J", "X", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
                                             "A", "S", "D", "F", "G", "H", "K", "L", "C", "V", "B", "N", "M", /*"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"*/};



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
            case "W":
                Win = KeyCode.W;
                break;
            case "E":
                Win = KeyCode.E;
                break;
            case "R":
                Win = KeyCode.R;
                break;
            case "T":
                Win = KeyCode.T;
                break;
            case "Y":
                Win = KeyCode.Y;
                break;
            case "U":
                Win = KeyCode.U;
                break;
            case "I":
                Win = KeyCode.I;
                break;
            case "O":
                Win = KeyCode.O;
                break;
            case "P":
                Win = KeyCode.P;
                break;
            case "A":
                Win = KeyCode.A;
                break;
            case "S":
                Win = KeyCode.S;
                break;
            case "D":
                Win = KeyCode.D;
                break;
            case "F":
                Win = KeyCode.F;
                break;
            case "G":
                Win = KeyCode.G;
                break;
            case "H":
                Win = KeyCode.H;
                break;
            case "K":
                Win = KeyCode.K;
                break;
            case "L":
                Win = KeyCode.L;
                break;
            case "C":
                Win = KeyCode.C;
                break;
            case "V":
                Win = KeyCode.V;
                break;
            case "B":
                Win = KeyCode.B;
                break;
            case "N":
                Win = KeyCode.N;
                break;
            case "M":
                Win = KeyCode.M;
                break;

        }
        
        // The currentLetter is will start as nothing befor it to be pick of a random letter
        currentLetter = "";
        
    }
}
