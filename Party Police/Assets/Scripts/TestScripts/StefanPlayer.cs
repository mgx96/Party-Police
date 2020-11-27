using UnityEngine;

public class StefanPlayer : MonoBehaviour
{

    public GameObject background;

    void Update()
    {
        float xBorder = (background.transform.localScale.x)/2;
        float yBorder = (background.transform.localScale.y)/2;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBorder, xBorder), Mathf.Clamp(transform.position.y, -yBorder, yBorder));

        //GUIUtility.ExitGUI();
    }
}
