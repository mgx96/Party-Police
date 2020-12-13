using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 10.0f;

    public Rigidbody2D rb;

    Vector2 movement;

    public bool canMove = true;

    public bool test = false;

    public Canvas canvas = null;

    void Start()
    {

    }

    private void Update()
    {
        if (!test)
        {
            if(!canMove)
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
    }
}
