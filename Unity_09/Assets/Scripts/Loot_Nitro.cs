using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Nitro : MonoBehaviour, ILoot
{

    public GameObject playerCentr;

    public void Profit()
    {
		Debug.Log("Nitro_profit");
        GameManager.lootNitro = true;
        //playerCentr.transform.position += new Vector3(0, 50, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
