using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush_boom : MonoBehaviour
{
    public GameObject prefab;
	private void Awake()
	{
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void     Boom(Vector3 position)
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
