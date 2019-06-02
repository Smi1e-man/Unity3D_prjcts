using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Bomb : MonoBehaviour, IBlocks
{
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        ;
    }
    public void Click()
    {
        //Destroy(gameObject);
    }
    public void Swipe()
    {
        //Vector3 vector = new Vector3(0, 0, 10);
        //GetComponent<Rigidbody>().AddForce(Vector3.right * 3, ForceMode.Impulse);
        Destroy(gameObject, 1F);

    }
    public void Crush()
    {
        GameManager.Stop_game();
        Destroy(gameObject);
    }
}
