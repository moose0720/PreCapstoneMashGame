using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public AnchoredMotor Motor;
    public GameObject DotPrefab;
    public GameData GameData;
    private GameObject activeDot;

    void Start()
    {
        Spawn();
        activeDot = GameObject.FindWithTag("Dot");
    }

    public void Spawn()
    {
        if(activeDot && GameData.CurrentLevel > 1)
        {
            Destroy(activeDot.gameObject);
        }

        if (GameData.DotsRemaining > 1)
        {
            var angle = Random.Range(20, 120);
            activeDot = Instantiate(DotPrefab, Motor.transform.position,
                                                                    Quaternion.identity,
                                                                                transform);

            activeDot.transform.RotateAround(transform.position, Vector3.forward,
                                                                    -angle * (int)Motor.Dir);
        }
        //RemoveDuplicates();

        //var angle = Random.Range(GameData.MinSpawnAngle, GameData.MaxSpawnAngle);
        //var go = Instantiate(SelectRandomDot(), Motor.transform.position, Quaternion.identity, transform);
        //go.transform.RotateAround(transform.position, Vector3.forward, -angle * (int)Motor.Dir);
    }

    /*GameObject SelectRandomDot()
    {
        if (Random.value < 0.2)
        {
            return StarredDotPrefab;
        }
        else
        {
            return DotPrefab;
        }
    }

    void RemoveDuplicates()
    {
        var dots = GameObject.FindGameObjectsWithTag("Dot");
        foreach (var dot in dots)
        {
            Destroy(dot);
        }
    }*/
} 
