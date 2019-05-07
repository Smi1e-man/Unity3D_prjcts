using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject[] blocks;
    float speed;

    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
		blocks = GameObject.FindGameObjectsWithTag("Block");

        foreach (GameObject block in blocks)
        {
            if (block.transform.position.y < 0)
                block.SendMessage("Crush");
            else if (Physics.Raycast(block.transform.position, Vector3.down, out hit) && hit.distance > block.transform.localScale.y + 0.1f)
                speed = (GameManager.G_score / 15) > 1 ? ((GameManager.G_score / 15) + 2.5f) : 3.5f;
            else
                speed = (GameManager.G_score / 15) > 1 ? (GameManager.G_score / 15) : 1.5f;
            MoveBlock(block);
        }
    }

    void MoveBlock(GameObject block)
    {
        Debug.Log(GameManager.G_score);
        Debug.Log(speed);
        block.transform.position += Vector3.down * Time.deltaTime * speed;
    }
}
