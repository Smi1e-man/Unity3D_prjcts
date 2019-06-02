using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHex : MonoBehaviour
{
    float rtt;

    // Start is called before the first frame update
    void Start()
    {
        rtt = Random.Range(0, 2);
        Debug.Log(rtt);
    }

    // Update is called once per frame
    void Update()
    {
        if (rtt == 1)
            transform.Rotate(Vector3.back, Time.deltaTime * 20f);
        else
            transform.Rotate(Vector3.forward, Time.deltaTime * 20f);
    }
}
