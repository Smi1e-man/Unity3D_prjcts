using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBolt : MonoBehaviour
{

    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = GetComponent<Rigidbody>().transform.forward * 35;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
