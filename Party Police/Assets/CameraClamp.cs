using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(target.position.x, -60f, 60f), Mathf.Clamp(target.position.y, -50f, 50f));
    }
}
