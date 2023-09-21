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
        public UnityEvent onScoreGame;
        public UnityEvent onScoreTake;
        private bool hasPrestAddKey;
        KeyCode addKey = KeyCode.L;
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
                addKey = mash.Win;
            }
            
            mashText.text = $"Mash: {mashScore.ToString()}";


            if (Input.GetKeyDown(addKey))
            {
            if(mash.Win == KeyCode.X)
                {
                    minusMashScore(); 
                    onScoreTake?.Invoke();
                    
                }
                else
                {
                addMashScore();
                onScoreGame?.Invoke();

                }

                hasPrestAddKey = false;
            }

            

        }

        public void addMashScore()
        {
            mashScore++;

            //mashText.text = mashScore.ToString();
        }

        public void minusMashScore()
        {
            mashScore--;
            
        }

    }
}