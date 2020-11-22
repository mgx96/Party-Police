using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 10.0f;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveUp = KeyCode.W;
    public KeyCode MoveDown = KeyCode.S;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(MoveRight))
        {
            gameObject.transform.position += new Vector3(1.0f * MovementSpeed, 0.0f, 0.0f) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(MoveLeft))
        {
            gameObject.transform.position -= new Vector3(1.0f * MovementSpeed, 0.0f, 0.0f) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(MoveUp))
        {
            gameObject.transform.position += new Vector3(0.0f, 1.0f * MovementSpeed, 0.0f) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(MoveDown))
        {
            gameObject.transform.position -= new Vector3(0.0f, 1.0f * MovementSpeed, 0.0f) * Time.deltaTime;
        }
    }
}
