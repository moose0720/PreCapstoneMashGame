using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public float xSpeed;
    public bool xMove = true;
    public float xBorder;
    // Start is called before the first frame update
    void Start()
    {
        xBorder = 400f; //the border on the x axis
        xSpeed = 1f; // the speed of the block from left to right
    }

    // Update is called once per frame
    void Update()
    {
        //block moving 
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y);
        }

        //block coming back and going the opposite direction when hitting the borders
        if (transform.position.x >= xBorder)
        {
            xMove = false;
        }

        if (transform.position.x <= -xBorder)
        {
            xMove = true;
        }
    }
}

