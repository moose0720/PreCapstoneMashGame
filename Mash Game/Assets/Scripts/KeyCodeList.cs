using System.Collections.Generic;
using UnityEngine;

public class KeyCodeList : MonoBehaviour
{
    private List<KeyCode> pressedKeys = new List<KeyCode>();

    void Update()
    {
        // Check for all possible key codes
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyCode))
            {
                // Add the pressed key to the list
                pressedKeys.Add(keyCode);
            }
        }

        // Example: Print the pressed keys
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrintPressedKeys();
        }
    }

    void PrintPressedKeys()
    {
        Debug.Log("Pressed Keys:");

        foreach (KeyCode keyCode in pressedKeys)
        {
            Debug.Log(keyCode);
        }
    }
}

