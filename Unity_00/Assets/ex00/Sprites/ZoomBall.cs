using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomBall : MonoBehaviour
{
    //public GameObject BallObject;
    public float Zoom;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= Zoom;
        }
        else
        {
            transform.localScale *= 0.99f;
        }
        if (transform.localScale.x < 0.2f || transform.localScale.x > 10)
        {
            Destroy(gameObject);
        }

    }
}
