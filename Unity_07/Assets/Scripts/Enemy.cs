using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Rigidbody rb;

    Vector3 deltaDistStart;
    Vector3 deltaDistWay;

    public GameObject player;
    public float speedDelta = 30;
    public float speed;

    public GameObject bolt;
    public GameObject spawnbolt;

    float nextFire = 2f;
    float fireRate = 2f;

    float timing;
    float deltTiming;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        timing = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        rb.position += Vector3.forward * speedDelta * Time.deltaTime;

        float moveH = Input.GetAxis("Horizontal");
        if (moveH == 0f)
        {
            deltTiming = Time.time - timing;
            rb.velocity = Vector3.zero;
        }
        else
        {
            timing = Time.time;
            StartCoroutine(Move(moveH));
        }
        if (deltTiming > nextFire)
        {
            //nextFire = Time.time + fireRate;
            timing = Time.time;
            Attack();
        }
    }

    IEnumerator Move(float moveH)
    {
        yield return new WaitForSeconds(0.8f);
        rb.velocity = new Vector3(moveH, 0f, 0f) * speed;
    }

    void Attack()
    {
        //yield return new WaitForSeconds(5f);
        Instantiate(bolt, spawnbolt.transform.position, spawnbolt.transform.rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
