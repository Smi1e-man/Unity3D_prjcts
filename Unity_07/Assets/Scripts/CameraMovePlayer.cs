using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovePlayer : MonoBehaviour
{
    public GameObject player;

    Vector3 deltaDimension;

    // Start is called before the first frame update
    void Start()
    {
        deltaDimension = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + deltaDimension;
    }
}
