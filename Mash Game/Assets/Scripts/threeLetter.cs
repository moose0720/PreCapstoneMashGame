using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class threeLetter : MonoBehaviour
{
    //public TMP_Text largeWord;
   /* public KeyCode Tw;

    public string currentWord = "";
    public string[] word = new string[] { "the", "tree", "bed" };

    public void randomWord()
    {
        string input = input.inputstring;
        if (input.Equals("")) //If we are not typing
            return; //Stop this function here
        char C = input[currentWord = word[Random.Range(0, word.Length)]];
        for(int i = 0; i < Tw.count; i++)
        {
            Word w = words[i];
            if(w.continueText(c))
            {
                string typed = w.GetType();
                if(typed.Equals(w.text)) //If what we typed is the word's text
                {
                    //we typed the whole word
                    Debug.Log("TYPED : " w.text);
                    break;
                }
            }
        }
        //largerWord.text = currentWord;
    }
    public void pickRandomMashWord()
    {
        randomWord();

        switch (currentWord)
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
        }
       
        currentWord = "";
    }
}

[System.Serializable]
public class Word
{
    public string text;
    public UnityEvent onTyped;
    string hasTyped = "";
    int curChar = 0;
}

public bool continueText(char C)
{
    if(C.Equals(text[curChar]))
    {
        curChar++;
        hasTyped = text.Substring(0, curChar);

        if(curChar >= text.Length) // If we typed the whole word
        {
            onTyped.Invoke();
            curChar = 0;
        }
        return true;
    }
    else
    {
        curChar = 0;
        hasTyped = "";
        return false;
    }

    public string getTyped()
    {
        return hasTyped;
    }*/
}