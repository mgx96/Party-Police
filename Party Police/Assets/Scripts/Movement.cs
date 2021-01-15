using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator anim;

    public float MovementSpeed = 10.0f;

    public Rigidbody2D rb;

    Vector2 movement;

    public bool isMoving = false;

    public bool canMove = true;

    public bool test = false;

    public Canvas canvas = null;

    public SpriteRenderer spriteRenderer;

    AudioSource audioSource;


    void Start()
    {
     
        anim = gameObject.GetComponent<Animator>();
        isMoving = false;

        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!test)
        {
            if (!canMove)
            {
                movement.x = 0;
                movement.y = 0;
            }
            else
            {
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");
            }
        }
        else
        {
            if (canvas.GetComponentInChildren<Transform>() != null)
            {
                movement.x = 0;
                movement.y = 0;
            }
            else
            {
                movement.x = Input.GetAxisRaw("Horizontal");
                movement.y = Input.GetAxisRaw("Vertical");
            }
        }
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * MovementSpeed * Time.fixedDeltaTime);
        anim.SetFloat("Speedx", movement.x);
        anim.SetFloat("Speedy", movement.y);
        if(movement.x != 0 || movement.y != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
       if (isMoving == true)
        {
            anim.SetBool("Moving", true);
        }
       else if(isMoving == false)
        {
            anim.SetBool("Moving", false);
        }

       if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
       else if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
            audioSource.Stop();

    }
}
