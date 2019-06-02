using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGenerator : MonoBehaviour
{
    public GameObject hexPrefab;
    public Transform hexTransform;
    public float spawnDelta = 1f;

    float nextSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            //Instantiate(hexPrefab, Vector3.zero, Quaternion.identity);
            Instantiate(hexPrefab, Vector3.zero , Quaternion.identity, hexTransform);
            nextSpawnTime = Time.time + 1 * spawnDelta;
        }
    }
}
