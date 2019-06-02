using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    Vector3 rotateDelta = new Vector3(0, 0, 60);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.eulerAngles += rotateDelta;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.eulerAngles -= rotateDelta;
        }
    }
}
