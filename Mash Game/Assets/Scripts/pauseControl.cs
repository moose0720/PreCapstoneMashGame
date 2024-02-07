using UnityEngine;

public class pauseControl : MonoBehaviour
{
    public GameObject pause;
    public static bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPause)
            {
                resumGame();
            }
            else
            {
                pauseGame();
            }
            Debug.Log("The p is being prest");
        }
    }

    public void pauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void resumGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}
