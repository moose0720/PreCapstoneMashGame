using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public GameData GameData;
    public Dir Dir = Dir.Clockwise;
    public GameEvent OnPaddleReset;
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
            transform.RotateAround(anchor.position, Vector3.forward, GameData.CurrentMotorSpeed * Time.deltaTime * -(int)Dir);
        }

        if (didTap && GameData.isRunning)
        {
            ChangeDirection();
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
            case Dir.Clockwise:
                Dir = Dir.AntiClockwise;
                break;
            case Dir.AntiClockwise:
                Dir = Dir.Clockwise;
                break;
        }
    }

    public void ResetPosition()
    {
        transform.localPosition = new Vector3(0, initialPos.y, 0);
        transform.localRotation = Quaternion.identity;

        OnPaddleReset.Raise();
    }
}

public enum Dir
{
    Clockwise = 1,
    AntiClockwise = -1
}