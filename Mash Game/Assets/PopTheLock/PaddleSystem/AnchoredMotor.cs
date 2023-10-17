using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public int Speed = 5;
    public Direction Dir = Direction.Clockwise;
    bool isRunning = false;

    Transform anchor;

    // Start is called before the first frame update
    void Start()
    {
        anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            transform.RotateAround(anchor.position, Vector3.forward, Speed * Time.deltaTime * -(int)Dir);
        }

        if (didTap)
        {
            if (!isRunning)
            {
                isRunning = true;
                return;
            }
           ChangeDir();
        }
    }

    bool didTap
    {
        get
        {
            return Input.GetKeyUp(KeyCode.Space);
        }
    }
    void ChangeDir()
    {
        switch(Dir)
        {
            case Direction.Clockwise:
                Dir = Direction.AntiClockwise;
                break;
            case Direction.AntiClockwise:
                Dir = Direction.Clockwise;
                break;
        }
    }
}

    public enum Direction
    {
        Clockwise = 1, 
        AntiClockwise = -1
    }