using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public GameData GameData;
    public Direction Dir = Direction.Clockwise;
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
        if (GameData.IsRunning)
        {
            transform.RotateAround(anchor.position, Vector3.forward, GameData.CurrentMotorSpeed * Time.deltaTime * -(int)Dir);
        }

        if (_didTap && GameData.IsRunning)
        {
            ChangeDirection();
        }
    }

    bool _didTap
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

        OnPaddleReset.Raise();
    }
}

public enum Direction
{
    Clockwise = 1,
    AntiClockwise = -1
}