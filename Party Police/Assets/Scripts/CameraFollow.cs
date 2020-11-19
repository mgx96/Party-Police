using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerPos;

    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3 (playerPos.position.x, playerPos.position.y, playerPos.position.z);
    }
}
