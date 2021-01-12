using UnityEngine;

public class StefanPlayer : MonoBehaviour
{

    void Update()
    {

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -57.2f, 90f), Mathf.Clamp(transform.position.y, -48.1f, 48.1f));
    }

    
}
