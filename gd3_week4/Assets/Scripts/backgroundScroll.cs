using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    Vector3 startPosition;
    public float moveSpeed;
    float bgWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        bgWidth = GetComponent<BoxCollider>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPosition.x - (bgWidth/2))
        {
            transform.position = startPosition;
        }

        if (GameObject.FindObjectOfType<spawnManager>().isGameOver == false)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
}
