using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class LevelTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshProUGUI Text;

    void Start()
    {
        Text = GetComponent<TMPro.TextMeshProUGUI>();
        Text.text = "Round: " + GameData.CurrentLevel.ToString();
    }

    void Update()
    {
        Text.text = "Round: " + GameData.CurrentLevel.ToString();
    }
}
