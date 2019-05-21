using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mr_Purple_Block : MonoBehaviour, IBlocks
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
        Destroy(gameObject);
    }
    public void Swipe()
    {
        Destroy(gameObject);

    }
    public void Crush()
    {
        GameManager.G_score--;
        //if (GameManager.G_score < 0)
            //GameManager.G_score = 0;
        Destroy(gameObject);
    }
}
