using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBlock : MonoBehaviour
{

	[SerializeField] float speed = 60f;
    [SerializeField] float deltaZ = 22f;

	GameObject player;

    Vector3 posPlayer;
    //[SerializeField] float distanceDump = 20f;

    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("player");
        posPlayer = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(posPlayer.x, 0f, posPlayer.z + deltaZ), speed * Time.deltaTime);         
    }
}
