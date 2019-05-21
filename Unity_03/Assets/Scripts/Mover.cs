using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject prefab;
    GameObject[] blocks;
    float speed;

    float speedDelta;

    RaycastHit hit;

    void Update()
    {
		blocks = GameObject.FindGameObjectsWithTag("Block");

        foreach (GameObject block in blocks)
        {
            if (block.transform.position.z < 0)
            {
                Vector3 pos = block.transform.position;
				block.SendMessage("Crush");
                prefab.GetComponent<Crush_boom>().Boom(pos);
            }
            else if (Physics.Raycast(block.transform.position, Vector3.back, out hit) && hit.distance > block.transform.localScale.z + 3f)
                speed = 3.5f;
            else
                speed = 2f;
            MoveBlock(block);
        }
        speedDelta = GameManager.G_score * 0.3f;
    }

    void MoveBlock(GameObject block)
    {
        block.transform.position += Vector3.back * Time.deltaTime * (speed + speedDelta);
    }
}
