using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypingWords : MonoBehaviour
{
    public TMP_Text wordDisplay;
    public TMP_InputField userInput;
    public TMP_Text scoreDisplay;

    private string[] words = { "cat", "dog", "sun", "sky", "red", "car" "run", "box", "pen", "cup", "bat", "sit", "hop"
                                "nod", "tip", "lip", "bug", "fan", "gem", "joy", "elf", "lab", "nut", "pig", "rag", "van",
                                 "ink", "log", "map", "nap", "oak", "pan", "ram", "sea", "toy", "yam", "zen", "bib", "egg",
                                    "kit", "leg", "tag", "wax", "zoo", "gig", "hay", "ice", "orb", "sum", "ant", "pie", "guy"};
    private int currentWordIndex = 0;
    private int score = 0;

    void Start()
    {
        DisplayNextWord();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            CheckWord();
        }
    }

    void DisplayNextWord()
    {
        if (currentWordIndex < words.Length)
        {
            string nextWord = words[currentWordIndex];
            wordDisplay.text = nextWord;
            userInput.text = "";
        }
        else
        {
            Debug.Log("Hi.");
        }
    }

    void CheckWord()
    {
        string enteredWord = userInput.text.ToLower();
        string correctWord = words[currentWordIndex].ToLower();

        if (enteredWord == correctWord)
        {
            score++;
            scoreDisplay.text = "Score: " + score.ToString();
        }

        currentWordIndex++;
        DisplayNextWord();
    }
}
