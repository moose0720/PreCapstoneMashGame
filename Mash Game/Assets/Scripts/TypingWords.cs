using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TypingWords : MonoBehaviour
{
    public List<Word> words;
    public TMP_Text display;
    private void Update()
    {
        string input = Input.inputString;
        if (input.Equals(""))//If we are not typing
            return; //Stops this function here
        char c = input[0];
        string typing = "";
        for (int i = 0; i < words.Count; i++)
        {
            Word w = words[i];
            if (w.continueText(c))
            {
                string typed = w.getTyped();
                typing += typing;
                if (typed.Equals(w.text))//If what we typed is the word's text
                {
                    Debug.Log("TYPED :" + w.text);
                    break;
                }
            }
        }
        display.text = typing;
    }
}


[System.Serializable]
public class Word
{
    public string text;
    public UnityEvent onTyped;
    string hasTyped = "";
    int curChar = 0;

    public Word(string t)
    {
        text = t;
        hasTyped = "";
        curChar = 0;
    }
    public bool continueText(char c)
    {
        if (c.Equals(text[curChar]))
        {
            curChar++;
            hasTyped = text.Substring(0, curChar);

            if (curChar >= text.Length)// If we typed the whole word
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
    }

    public string getTyped()
    {
        return hasTyped;
    }
}