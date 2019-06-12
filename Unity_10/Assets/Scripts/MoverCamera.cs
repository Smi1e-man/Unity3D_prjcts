using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamera : MonoBehaviour
{
    [SerializeField] GameObject player = null;

    Vector3 offset;
    //Quaternion offsetRot;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        //offsetRot = transform.rotation - player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation + offsetRot;

    }
}
