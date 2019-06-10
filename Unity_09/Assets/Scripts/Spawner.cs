using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject gold;
    public GameObject nitro;

    public Transform loot;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(RandLoot(), loot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        if (GameManager.needSpawn)
        {
            Debug.Log("Spawn");         
			Instantiate(RandLoot(), loot);
            GameManager.needSpawn = false;
        }

    }

    public GameObject        RandLoot()
    {
        float i = Random.Range(0, 2);
        float angle = Random.Range(0f, 360f);
        float distance = Random.Range(15f, 100f);

        float _x = distance * Mathf.Cos(angle);
        float _z = distance * Mathf.Sin(angle);

        if (i == 1)
        {
            nitro.transform.position = new Vector3(_x, 0, player.transform.position.z + _z);
			return nitro;
        }
        else
        {
            gold.transform.position = new Vector3(_x, 0, player.transform.position.z + _z);
			return gold;
        }
    }
}
