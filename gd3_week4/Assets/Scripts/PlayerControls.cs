using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;

    public bool isGrounded;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }

        if(collision.transform.tag == "Obstacle")
        {
            GameObject.FindObjectOfType<spawnManager>().isGameOver = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
