using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCar : MonoBehaviour
{

    [SerializeField] GameObject leftCentreRotate = null;
    [SerializeField] GameObject rightCentreRotate = null;
    [SerializeField] GameObject forwardCentre = null;
	[SerializeField] float speed = 0f;
    [SerializeField] float speedAround = 0f;
    [SerializeField] float radiusAround = 0f;


    // Start is called before the first frame update
    void Start()
    {
		leftCentreRotate.transform.position = Vector3.left * radiusAround;
        rightCentreRotate.transform.position = Vector3.right * radiusAround;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode))
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("Left");
            transform.RotateAround(leftCentreRotate.transform.position, Vector3.down, speedAround * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("Right");
            transform.RotateAround(rightCentreRotate.transform.position, Vector3.up, speedAround * Time.deltaTime);
        }
        else
        {
            Vector3 deltDist = (forwardCentre.transform.position - transform.position).normalized;
            transform.rotation = Quaternion.LookRotation(deltDist);
            //transform.position += Vector3.forward * speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, forwardCentre.transform.position, speed * Time.deltaTime);
            
        }

    }
}
