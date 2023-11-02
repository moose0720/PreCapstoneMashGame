using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public GameData GameData;
    public int Speed = 5;
    public Direction Dir = Direction.Clockwise;
    public GameEvent PaddleReset;
    Vector3 initialPos;
    Transform anchor;
    

    void Start()
    {
        anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        initialPos = GetComponent<Transform>().localPosition;
    }

    void Update()
    {
        if (GameData.isRunning)
        {
            transform.RotateAround(anchor.position, Vector3.forward,
                                                      Speed * Time.deltaTime
                                                             * -(int) Dir);
        }

        if (didTap && GameData.isRunning)
        {
            if(!GameData.isRunning)
            {
                ChangeDirection();
            }
        }
    }

    bool didTap
    {
        get
        {
            return (Input.GetKeyUp(KeyCode.Space));
    }
        } 

    void ChangeDirection()
    {
        switch (Dir)
        {
            case Direction.Clockwise:
                Dir = Direction.AntiClockwise;
                break;
            case Direction.AntiClockwise:
                Dir = Direction.Clockwise;
                break;
        }
    }

    public void ResetPosition()
    {
        
        transform.localPosition = new Vector3(0, initialPos.y, 0);
        transform.localRotation = Quaternion.identity;
        //GameData.isRunning = false;
        PaddleReset.Raise();
    } 

}

public enum Direction
{
    Clockwise = 1,
    AntiClockwise = -1
}