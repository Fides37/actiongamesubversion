using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public float speed = 3f;
    public Rigidbody2D rb;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = CatMovement();

        Debug.Log(rb.velocity);
    }

    private Vector2 CatMovement()
    {
        Vector2 vel = rb.velocity;

        if (Input.GetKey(KeyCode.W))
        {
            vel.y = speed;

            animator.SetBool("isWalkingVert", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            vel.y = -speed;

            animator.SetBool("isWalkingVert", true);

        }
        else
        {
            vel.y = 0;
            animator.SetBool("isWalkingVert", false);

        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = speed;
            animator.SetBool("isWalkingHori", true);
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            vel.x = -speed;
            animator.SetBool("isWalkingHori", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            vel.x = 0;
            animator.SetBool("isWalkingHori", false);

        }

        return vel;

    }


}
