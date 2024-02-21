using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class TypingWords : MonoBehaviour
{
    public TMP_Text wordDisplay;
    public InputField inputField;
    public TMP_Text scoreText;

    private List<string> threeLetterWords = new List<string> { "CAT", "DOG", "SUN", "SKI", "BOX" };
    private int currentWordIndex = 0;
    private int score = 0;

    void Start()
    {
        DisplayCurrentWord();
    }

    void DisplayCurrentWord()
    {
        // Display the current word on the screen
        wordDisplay.text = threeLetterWords[currentWordIndex];
    }

    public void OnSubmit()
    {
        // Check if the entered word is correct
        if (inputField.text.ToUpper() == threeLetterWords[currentWordIndex])
        {
            // Add a point to the score
            score++;
            scoreText.text = "Score: " + score;

            // Move to the next word
            currentWordIndex = (currentWordIndex + 1) % threeLetterWords.Count;

            // Display the new word on the screen
            DisplayCurrentWord();
        }
        else
        {
            Debug.Log("Incorrect. Try again!");
            // Add your logic for what happens when the player enters an incorrect word
        }

        // Clear the input field
        inputField.text = "";
    }
}