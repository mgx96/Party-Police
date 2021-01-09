using UnityEngine;

public class StefanPlayer : MonoBehaviour
{

    public GameObject border;

    void Update()
    {
        float xBorder = (border.transform.localScale.x)/2;
        float yBorder = (border.transform.localScale.y)/2;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBorder, xBorder), Mathf.Clamp(transform.position.y, -yBorder, yBorder));
    }

    
}
