using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public Vector3 spawnPoint;
    public int score;
    public TMP_Text scoreText, timePassedText;
    public bool isGameOver = false;
    float timePassed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", 3,3);
    }
    private void Update()
    {
        if (isGameOver == true)
        {
            CancelInvoke("spawnObstacle");
        }
        else
        {
            scoreText.text = "Score : " + score.ToString();
            timePassedText.text = "Time : " + timePassed.ToString("F1");
            timePassed = Time.time;
        }

      
       // timePassed.ToString("F2");
       

    }
    void spawnObstacle()
    {
        int index = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[index], spawnPoint, obstaclePrefab[index].transform.rotation);
    }
}
