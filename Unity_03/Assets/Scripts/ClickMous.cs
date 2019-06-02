using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMous : MonoBehaviour
{
    Vector3 downClick;
    Vector3 upClick;

    void OnMouseDown()
    {
        gameObject.GetComponent<IBlocks>().Click();
        downClick = Input.mousePosition;
    }

	private void OnMouseUp()
	{
        upClick = Input.mousePosition;
	}

    void Update()
    {
        if (upClick.x > downClick.x)
        {
            gameObject.GetComponent<IBlocks>().Swipe();
        }
    }

}
