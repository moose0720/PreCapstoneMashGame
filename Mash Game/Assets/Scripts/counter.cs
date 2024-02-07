using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    //using UnityEngine.UI;

    public class counter : MonoBehaviour
    {
        public int mashScore;
        public int highMashScore;
        public int yourMash;
        public TMP_Text mashText;
        public TMP_Text highMashScoreText;
        public TMP_Text yourMashScore;
        //public TMP_Text wordText;
        public randomMash mash;
        //public threeLetter three;
        public UnityEvent onScoreGame;
        public AudioSource sound;
        private bool hasPrestAddKey;
        KeyCode addKey = KeyCode.L;
        //KeyCode addWord = KeyCode.T;
        public GameObject myCheat;
        // Start is called before the first frame update

        void Start()
        {
            highMashScore = PlayerPrefs.GetInt("highMashScore");
        }

        // Update is called once per frame
        void Update()
        {
            if (!hasPrestAddKey)
            {
                hasPrestAddKey = true;
                mash.pickRandomMashLetter();
                addKey = mash.Win;
            }

            mashText.text = $"Mash: {mashScore}";
            highMashScoreText.text = $"High Mash: {highMashScore}";
            yourMashScore.text = $"Your Mash: {yourMash}";


            if (Input.GetKeyDown(addKey))
            {
                addMashScore();
                onScoreGame?.Invoke();

                hasPrestAddKey = false;
            }

            if (mashScore > highMashScore)
            {
                PlayerPrefs.SetInt("highMashScore", mashScore);
            }
            if (mashScore < highMashScore)
            {
                PlayerPrefs.SetInt("yourMash", mashScore);
            }
        }

        public void addMashScore()
        {
            sound.Play();
            mashScore++;
            // PlayerPrefs.SetInt("Mash Score", mashScore);
            //int myScore = PlayerPrefs.GetInt("Mash Score");
        }

        public void subMashScore()
        {
            mashScore--;
        }
    }
}