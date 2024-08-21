using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float moveSpeed;
    public float leftBound;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindObjectOfType<spawnManager>().isGameOver == false)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        

        if(transform.position.x < leftBound)
        {
            GameObject.FindObjectOfType<spawnManager>().score++;
            Debug.Log(GameObject.FindObjectOfType<spawnManager>().score);
            Destroy(gameObject);

        }
    }
}
