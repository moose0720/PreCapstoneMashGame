using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class threeLetter : MonoBehaviour
{
    //public TMP_Text largeText;
    public KeyCode Tw;

    public string currentWord = "";
    public string[] word = new string[] { "the", "tree", "bed" };

    public void randomWord()
    {
        currentWord = word[Random.Range(0, word.Length)];
        //largerText.text = currentWord;
    }
    public void pickRandomMashWord()
    {
        randomWord();

        /*switch (currentWord)
        {
            case "the":
                Tw = KeyCode.the;
                break;
            case "tree":
                Tw = KeyCode.tree;
                break;
            case "bed":
                Tw = KeyCode.bed;
                break;
        }*/

        currentWord = "";
    }
}
