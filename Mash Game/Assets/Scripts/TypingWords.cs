using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TypingWords : MonoBehaviour
{
    public TMP_Text wordDisplay;
    public TMP_Text scoreDisplay;
    private bool hasTypedWord;

    private string currentWord;
    private int score = 0;

    private string[] wordList = { "cat", "dog", "bat", "hat", "sun", "pen" };

    private void Start()
    {
        UpdateWord();
    }

     void Update()
    {
        if(!hasTypedWord)
        {
              hasTypedWord = true;
              CheckInput();

        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
              UpdateWord();
            hasTypedWord = false;
        }
    }

    void UpdateWord()
    {
        currentWord = GetRandomWord();
        wordDisplay.text = currentWord;
    }

     void CheckInput()
    {
        string userInput = wordDisplay.text.ToLower();

        if (userInput.Length == 3 && userInput == currentWord)
        {
            score++;
            hasTypedWord = true;
            scoreDisplay.text = "Score: " + score.ToString();
            Debug.Log("Correct! You gained a point.");
        }
        else
        {
            Debug.Log("Incorrect! Try again.");
        }
    }

    string GetRandomWord()
    {
        return wordList[Random.Range(0, wordList.Length)];
    }
}