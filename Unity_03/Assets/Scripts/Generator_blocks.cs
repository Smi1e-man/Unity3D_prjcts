using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_blocks : MonoBehaviour
{
    public GameObject prefab;

    public Material Grey_mtrl;
    public Material Purple_mtrl;
    public Material Bomb_mtrl;

    GameObject[] blocks;

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
        if (blocks.Length < 10)
            LastBlock = CreateBlock(LastBlock);
    }

    GameObject      CreateBlock(GameObject LastBlock)
    {
        newPos = LastBlock.transform.position;
        newPos.y += LastBlock.transform.localScale.y * (2 + Random.Range(0.5f, 1.2f));
        GameObject newBlock = Instantiate(prefab, newPos, Quaternion.identity);
        delegators[Random.Range(Random.Range(0, 2), 3)](newBlock);
        return newBlock;
    }

    void Grey_block(GameObject block)
    {
        block.AddComponent<Mr_Grey_Block>();
        block.GetComponent<MeshRenderer>().material = Grey_mtrl;
    }
    void Purple_block(GameObject block)
    {
        block.AddComponent<Mr_Purple_Block>();
        block.GetComponent<MeshRenderer>().material = Purple_mtrl;
    }
    void Bomb_block(GameObject block)
    {
        block.AddComponent<Mr_Bomb_Block>();
        block.GetComponent<MeshRenderer>().material = Bomb_mtrl;
    }
}
