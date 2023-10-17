using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public int Speed = 5;
    public Direction Dir = Direction.Clockwise;

    Transform anchor;

    // Start is called before the first frame update
    void Start()
    {
        anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(anchor.position, Vector3.forward, Speed * Time.deltaTime * -(int)Dir);
    }
}

    public enum Direction
    {
        Clockwise = 1, 
        AntiClockwise = -1
    }