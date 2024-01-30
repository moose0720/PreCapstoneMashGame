using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

namespace Assets.Scripts
{
    //using UnityEngine.UI;

    public class counter : MonoBehaviour
    {
        public int mashScore;
        public TMP_Text mashText;
        public randomMash mash;
        public threeLetter three;
        public UnityEvent onScoreGame;
        public AudioSource sound;
        private bool hasPrestAddKey;
        KeyCode addKey = KeyCode.L;
        public GameObject myCheat;
        // Start is called before the first frame update

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(!hasPrestAddKey)
            {
                hasPrestAddKey = true;
                mash.pickRandomMashLetter();
                three.pickRandomMashWord();
                addKey = mash.Win;
                addKey = three.Tw;
            }
            
            mashText.text = $"Mash: {mashScore}";


            if (Input.GetKeyDown(addKey))
            {
                addMashScore();
                onScoreGame?.Invoke();

                hasPrestAddKey = false;
            }

            

        }

        public void addMashScore()
        {
            sound.Play();
            mashScore++;
           // PlayerPrefs.SetInt("Mash Score", mashScore);
            //int myScore = PlayerPrefs.GetInt("Mash Score");
        }
    }  
}