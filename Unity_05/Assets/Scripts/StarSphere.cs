using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSphere : MonoBehaviour
{
    Vector3 newPos;

    // Start is called before the first frame update
    void Start()
    {
        newPos = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        ;
    }

	public void OnDestroy()
	{
        Destroy(gameObject);
	}
}
