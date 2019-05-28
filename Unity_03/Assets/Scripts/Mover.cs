using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject[] blocks;

    float speed;
    float speedDelta;

    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.G_move_game == 1)
        {
			blocks = GameObject.FindGameObjectsWithTag("Block");
			
			foreach (GameObject block in blocks)
			{
				if (block.transform.position.y < 0)
					block.SendMessage("Crush");
				else if (Physics.Raycast(block.transform.position, Vector3.down, out hit) && hit.distance > block.transform.localScale.y + 3f)
					speed = 4.5f;
				else
					speed = 2.5f;
				MoveBlock(block);
			}
            speedDelta = GameManager.G_score * 0.3f;   
        }
    }

    void MoveBlock(GameObject block)
    {
        block.transform.position += Vector3.down * Time.deltaTime * (speed + speedDelta);
    }
}
