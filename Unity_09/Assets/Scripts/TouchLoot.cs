using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<ILoot>().Profit();
        Destroy(other.gameObject);
        GameManager.needSpawn = true;
    }
}
