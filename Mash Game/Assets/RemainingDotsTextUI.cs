using UnityEngine;

public class RemainingDotsTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshPr text;

    void Start()
    {
        text = GetComponent<TMPro.TextMeshPro>();
        text.text = GameData.DotsRemaining.ToString();
    }

    void Update()
    {
        text.text = GameData.DotsRemaining.ToString();
    }
}
