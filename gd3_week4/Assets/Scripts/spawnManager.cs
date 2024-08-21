using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public Vector3 spawnPoint;
    public int score;

    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", 3,3);
    }
    private void Update()
    {
        if(isGameOver == true) CancelInvoke("spawnObstacle");
    }
    void spawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[index], spawnPoint, obstaclePrefab[index].transform.rotation);
    }
}
