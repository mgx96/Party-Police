using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapClamp : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -67f, 67f), Mathf.Clamp(transform.position.y, -60f, 60f));
    }
}
