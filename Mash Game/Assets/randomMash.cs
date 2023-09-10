using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomMash : MonoBehaviour
{
    public TMP_Text largeText;
    // Update is called once per frame
    void Update()
    {
        pickRandomMashLetter();
    }

    private void pickRandomMashLetter()
    {
        string[] letter = new string[] { "Z", "Q", "J" };
        string randomMash = letter[Random.Range(0, letter.Length)];
        largeText.text = randomMash;
    }
}
