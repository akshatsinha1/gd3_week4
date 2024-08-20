using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", 3,3);
    }

    void spawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[index], spawnPoint, obstaclePrefab[index].transform.rotation);
    }
}
