using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    public GameObject airplane;

    float distance = 30f;
    float angle;

    Vector3 nPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //transform.position = new Vector3(airplane.transform.position.x * 2, airplane.transform.position.y, airplane.transform.position.z * 2);
            //Debug.Log(transform.position);
            //angle = Vector3.Angle(transform.position, airplane.transform.position);
            //Debug.Log(angle);
            if (GameManager.trend)
                GameManager.trend = false;
            else
                GameManager.trend = true;

            nPos = airplane.transform.position;
            transform.position = new Vector3(airplane.transform.position.x * 2 - transform.position.x, transform.position.y, airplane.transform.position.z * 2 - transform.position.z);
            airplane.transform.position = nPos;
        }
    }

 //   private void OnMouseDown()
 //   {
 //       //distance = Vector3.Distance(transform.position, airplane.transform.position);
 //       //transform.position = Vector3.MoveTowards(transform.position, )
	//}
}
