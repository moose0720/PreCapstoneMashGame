using UnityEngine;
namespace Assets.Scripts
{
    public class ScoreBasedSkybox : MonoBehaviour
    {
        public  MSCounter MScore;
        public Material[] skyboxes;
        private int currentSkyBoxIndex = 0;
        // Start is called before the first frame update
        void Start()
        {
            RenderSettings.skybox = skyboxes[currentSkyBoxIndex];
        }

        // Update is called once per frame
        void Update()
        {
           int scoreValue = MScore.mashScore; // mashScore returns the current score value

            if (scoreValue >= 20 && currentSkyBoxIndex == 0) // Change to the second skybox when score reaches 20
            {
                currentSkyBoxIndex = 1;
                RenderSettings.skybox = skyboxes[currentSkyBoxIndex];
            }

            if(scoreValue >= 40 && currentSkyBoxIndex == 1)
            {
                currentSkyBoxIndex = 2;
                RenderSettings.skybox = skyboxes[currentSkyBoxIndex];
            }
        }
    }
}
