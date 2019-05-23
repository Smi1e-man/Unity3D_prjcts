using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_blocks : MonoBehaviour
{
    public GameObject prefab;
    public GameObject bomb;

    public Material Grey_mtrl;
    public Material Purple_mtrl;
    public Material Bomb_mtrl;

    float distanceDelta = 0f;

    GameObject[] blocks;
    GameObject newBlock;

    GameObject LastBlock;

    Vector3 newPos;

    delegate void NewDelegate(GameObject block);

    NewDelegate[] delegators;

    // Start is called before the first frame update
    void Start()
    {
        delegators = new NewDelegate[]{ Grey_block, Purple_block, Bomb_block };
        LastBlock = GameObject.FindGameObjectWithTag("Block");
    }

    // Update is called once per frame
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");
        if (blocks.Length < 30)
            LastBlock = CreateBlock(LastBlock);
        distanceDelta = GameManager.G_score * 0.1f;
    }

    GameObject  CreateBlock(GameObject LastBlock)
    {
        //Debug.Log(distanceDelta);
        newPos = LastBlock.transform.position;
        newPos.z += LastBlock.transform.localScale.z * (Random.Range(1f + distanceDelta, 2f + distanceDelta));

        int nb_block = Random_block();
        if (nb_block == 2)
        {
			newPos.y = 3.3f;         
            newBlock = Instantiate(bomb, newPos, LastBlock.transform.rotation);
        }
        else
        {
            newPos.y = 3.86f;         
			newBlock = Instantiate(prefab, newPos, LastBlock.transform.rotation);
        }
        delegators[nb_block](newBlock);
        return newBlock;
    }

    int         Random_block()
    {
        int random = Random.Range(0, 100);
        if (random < 10)
            return(2);
        else if (random < 50)
            return(1);
        else
            return(0);
    }

    void        Grey_block(GameObject block)
    {
        block.AddComponent<Mr_Grey_Block>();
        block.GetComponent<MeshRenderer>().material = Grey_mtrl;
    }
    void        Purple_block(GameObject block)
    {
        block.AddComponent<Mr_Purple_Block>();
        block.GetComponent<MeshRenderer>().material = Purple_mtrl;
    }
    void        Bomb_block(GameObject block)
    {
        block.AddComponent<Mr_Bomb_Block>();
        block.GetComponent<MeshRenderer>().material = Bomb_mtrl;
    }
}
