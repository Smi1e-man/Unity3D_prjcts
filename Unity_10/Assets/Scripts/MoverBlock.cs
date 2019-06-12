using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBlock : MonoBehaviour
{

    [SerializeField] GameObject player;

    [SerializeField] float timeDumping = 3f;

    [SerializeField] float speed = 60f;
    [SerializeField] float distanceDump = 20f;

    Rigidbody rb;

    float timeDump;

    Vector3 posPlayer = Vector3.zero;

    bool check = true;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timeDump = Time.time + timeDumping;

        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeDump > Time.time)
        {
            transform.position = player.transform.position + offset;
        }
        if (timeDump <= Time.time && check)
        {
            posPlayer = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + distanceDump);
            check = false;
            Debug.Log(posPlayer);
        }
        if (posPlayer != Vector3.zero)
        {
            //rb.position = new Vector3(rb.position.x, rb.position.y, rb.position.z + 5f);
            rb.transform.position = Vector3.MoveTowards(transform.position, posPlayer, speed * Time.deltaTime);
        }
        //if (transform.position.y <= 0f)
        //{
        //    timeDump = Time.time + timeDumping;
        //    transform.position = new Vector3(0f, 20f, 0f);
        //    check = true;
        //    posPlayer = Vector3.zero;
        //}
    }
}
