using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{

    private bool canClick = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0) && canClick)
        {
            Destroy(gameObject);
        }
    }

    public void SetCanClick(bool can)
    {
        canClick = can;
    }
}
