using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public AnchoredMotor Motor;
    public GameObject DotPrefab;
    public GameData GameData;


    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        
            var angle = Random.Range(GameData.MinSpawnAngle, GameData.MaxSpawnAngle);
            var go = Instantiate(DotPrefab, Motor.transform.position,
                                                                    Quaternion.identity,
                                                                                transform);

            go.transform.RotateAround(transform.position, Vector3.forward,
                                                                    -angle * (int)Motor.Dir);
    }

    void RemoveDuplicates()
    {
        var dots = GameObject.FindGameObjectsWithTag("Dot");
        foreach (var dot in dots)
        {
            Destroy(dot);
        }
    }
} 
