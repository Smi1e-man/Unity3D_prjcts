using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;

    public float speed; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    rb.position += Vector3.left * 3;
        //    //rb.transform.Rotate(Vector3.zero, 30);
        //}

        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    rb.position += Vector3.right * 3;
        //}
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(move, 0f, 0f) * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
