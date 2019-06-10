using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{

    public Transform loot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x == player.transform.position.x || transform.position.z == player.transform.position.z)
            //Destroy(gameObject);
    }

	private void OnTriggerEnter(Collider other)
	{
        //Debug.Log("???");
        //GetComponent<>
        //if (other.GetComponent<Spawner>() != null) {
        //}

        //other.

        Destroy(other.gameObject);
        GameManager.needSpawn = true;
	}

	//private void o(Collision collision)
  //  {
		//Debug.Log("ENTER");
    //    //Debug
    //}


}
