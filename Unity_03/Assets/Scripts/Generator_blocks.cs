using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_blocks : MonoBehaviour
{
    public GameObject prefab;
    public GameObject bomb;

    public Material Good_mtrl;
    public Material Bad_mtrl;
    public Material Bomb_mtrl;

    float distanceDelta;

    GameObject[] blocks;
    GameObject newBlock;

    GameObject LastBlock;

    Vector3 newPos;

    delegate void NewDelegate(GameObject block);

    NewDelegate[] delegators;

    // Start is called before the first frame update
    void Start()
    {
        delegators = new NewDelegate[]{ Good_block, Bad_block, Bomb_block };
        LastBlock = GameObject.FindGameObjectWithTag("Block");
    }

    // Update is called once per frame
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");
        if (blocks.Length < 20)
            LastBlock = CreateBlock(LastBlock);
        distanceDelta = GameManager.G_score * 0.4f;
    }

    GameObject      CreateBlock(GameObject LastBlock)
    {
        newPos = LastBlock.transform.position;
        newPos.y += LastBlock.transform.localScale.y * (Random.Range(6f + distanceDelta, 10f + distanceDelta));

        int nb_block = Random_block();
        if (nb_block == 2)
        {
            newPos.y += 3f;
            newBlock = Instantiate(bomb, newPos, LastBlock.transform.rotation);
        }
        else
        {
            newBlock = Instantiate(prefab, newPos, LastBlock.transform.rotation);
        }

        delegators[nb_block](newBlock);
        return newBlock;
    }

    int Random_block()
    {
        int random = Random.Range(0, 100);

        if (random < 10)
            return (2);
        else if (random < 50)
            return (1);
        else
            return (0);
    }

    void Good_block(GameObject block)
    {
        block.AddComponent<Block_Good>();
        block.GetComponent<MeshRenderer>().material = Good_mtrl;
    }
    void Bad_block(GameObject block)
    {
        block.AddComponent<Block_Bad>();
        block.GetComponent<MeshRenderer>().material = Bad_mtrl;
    }
    void Bomb_block(GameObject block)
    {
        block.AddComponent<Block_Bomb>();
        block.GetComponent<MeshRenderer>().material = Bomb_mtrl;
    }
}
