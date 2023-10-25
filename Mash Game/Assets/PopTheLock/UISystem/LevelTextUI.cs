using UnityEngine;

public class LevelTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshProUGUI _text;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
}*/
=======
=======
>>>>>>> parent of 9cad1e7 (Start Over)
    void Start()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }

    void Update()
    {
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }
}
>>>>>>> parent of 9cad1e7 (Start Over)
=======
}
>>>>>>> parent of e138493 (Saving point)
