using UnityEngine;

public class RemainingDotsTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshPro Text;

    void Start()
    {
        Text = GetComponent<TMPro.TextMeshPro>();
        Text.text = GameData.DotsRemaining.ToString();
    }

    void Update()
    {
        Text.text = GameData.DotsRemaining.ToString();
    }
} 
