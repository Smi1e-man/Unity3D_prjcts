using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    [SerializeField] GameObject pref = null;
    [SerializeField] GameObject pref2 = null;

    [SerializeField] float timeOnDump = 3f;
    float timeDump;

    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        timeDump = Time.time + timeOnDump;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeDump <= Time.time)
        {
            Instantiate(RandBlock(), transform.position, Quaternion.identity);
			timeDump = Time.time + timeOnDump;
        }
    }

    GameObject RandBlock()
    {
        if (check)
        {
            check = false;                  
			return pref;
        }
        else
        {
            check = true;
			return pref2;
        }
    }
}
