using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBlockTwo : MonoBehaviour
{
    [SerializeField] float speed = 60f;
    [SerializeField] float deltaZ = 22f;
    [SerializeField] float deltaX = 1f;

    GameObject player;

    Vector3 posPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        posPlayer = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(posPlayer.x + deltaX, 0f, posPlayer.z + deltaZ), speed * Time.deltaTime);
    }
}
