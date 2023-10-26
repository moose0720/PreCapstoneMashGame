using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color startColor;
    public Color loseColor;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.backgroundColor = startColor
    }

    
    public void changeToLoseColor()
    {
        cam.backgroundColor = loseColor;
    }

    public void changeToStartColor()
    {
        cam.backgroundColor = startColor;
    }
}
