using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;

    public bool isGrounded;
    public float gravityModifier;

    Animator anim;
    public Animator lemmyAnimator;

    public ParticleSystem dirtSplatter;

    [SerializeField] spawnManager sm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetTrigger("Jump_trig");
            lemmyAnimator.SetTrigger("jump");
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            isGrounded = true;
            dirtSplatter.Play();
        }

        if(collision.transform.tag == "Obstacle")
        {
            sm.isGameOver = true;
            Debug.Log("collided");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = false;
            dirtSplatter.Stop();
        }
    }
}
