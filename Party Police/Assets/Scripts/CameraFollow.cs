using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerPos;
    [SerializeField]
    float cameraDistance = -2f;

    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3 (playerPos.position.x, playerPos.position.y, cameraDistance);
        
    }
}
