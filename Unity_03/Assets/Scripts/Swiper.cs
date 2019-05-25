using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiper : MonoBehaviour
{
    Vector3 point1;
    Vector3 point2;
    Vector3 distance;

	private void OnMouseDown()
	{
        point1 = Input.mousePosition;
        //Debug.Log(point1);
	}

	private void OnMouseUp()
	{
        point2 = Input.mousePosition;
        //Debug.Log(point2);
	}

	private void Update()
	{
        if (point1.x != point2.x)
        {
            Debug.Log("Swipe");
            gameObject.GetComponent<IBlocks>().Swipe();
        }
        //Debug.Log(Input.mousePosition);
	}
}
