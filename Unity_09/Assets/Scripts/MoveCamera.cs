using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    //public GameObject planeCentre;
    public GameObject player;

    //public float speed = 60f;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; //focus_player

        //offset = transform.position - planeCentre.transform.position; //focus_centre
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; //focus_player

        //transform.position = Vector3.MoveTowards(transform.position, planeCentre.transform.position + offset, speed * Time.deltaTime); //focus_centre
    }
}
