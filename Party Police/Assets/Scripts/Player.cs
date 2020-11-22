using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -22.79f, 22.79f), Mathf.Clamp(transform.position.y, -15.019f, 15.019f));

        GUIUtility.ExitGUI();
    }
}
