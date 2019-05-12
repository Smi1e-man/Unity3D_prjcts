using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    GameObject[] lenghtEl;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lenghtEl = GameObject.FindGameObjectsWithTag("SphereStar");
        if (lenghtEl.Length == 0 && 
            cube.GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0))
        {
            SpawnSphere();
        }
    }

    void    SpawnSphere()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(sphere);
        }
    }
}
