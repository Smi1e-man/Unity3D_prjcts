using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class Mover : MonoBehaviour
{

    Vector3 target;
    Rigidbody myRigidbody;

    public Material normal_material;
    public Material highlight_material;

    bool click = false;

	void Awake()
	{
        myRigidbody = GetComponent<Rigidbody>();
	}

	void Start()
    {
        ;
    }

	void OnMouseUp()
	{
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0;
        GetComponent<Renderer>().material = normal_material;
		click = true;
    }

    void OnMouseDown()
    {
        myRigidbody.velocity = new Vector3(0, 0, 0);
        GetComponent<Renderer>().material = highlight_material;
    }

    void Update()
    {
        if (click)
        {
            myRigidbody.AddForce(target * 2, ForceMode.Impulse);
            click = false;
        }
    }

	void OnTriggerStay(Collider other)
	{
        other.gameObject.GetComponent<StarSphere>().OnDestroy();
        Debug.Log("Crush");
	}
}
