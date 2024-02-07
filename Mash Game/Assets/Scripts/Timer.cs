using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private static float deltaTime;
    public TMP_Text TimeText;
    public float currentTime = 30;

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        TimeText.text = $"Time: {(int)currentTime} seconds"; // calculates the time
        if (currentTime <= 0)
        {
            SceneManager.LoadScene("End"); //when time = 0 go to the end scene
        }
    }
}
