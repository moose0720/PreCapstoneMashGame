using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class randomMash : MonoBehaviour
{
    public TMP_Text largeText;
    // Update is called once per frame
    void Update()
    {
        pickRandomMashLetter();
    }
    // This will randomly pick the letter Z,Q,J. Update it to slow down for the player can see the letter.
    private void pickRandomMashLetter()
    {
        string[] letter = new string[] { "Z", "Q", "J" };
        string randomMash = letter[Random.Range(0, letter.Length)];
        largeText.text = randomMash;
    }
}
