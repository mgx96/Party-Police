using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform playerPos;

    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(playerPos.position.x, -60f, 60f), Mathf.Clamp(playerPos.position.y, -50f, 50f));
    }
}
