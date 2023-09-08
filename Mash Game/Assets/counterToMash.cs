using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class counterToMash : MonoBehaviour
{
    public int mashScore;
    public TMP_Text mashText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mashText.text = $"Mash: {mashScore.ToString()}";
        if (Input.GetKeyDown(KeyCode.Z))
        {
            addMashScore();
            Debug.Log("The z is being prest");
        }

    }

    void addMashScore()
    {
        mashScore++;

        //mashText.text = mashScore.ToString();
    }

}
