using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveRotate : MonoBehaviour
{
    public GameObject airplane;

    public float speedAround = 60f;
    public float speedDown = 10f;

    public float timeUP = 5f;
    float timeNeeded;

    float deltaHeight = 30;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.heightPlane = transform.position.y;
            
        if (GameManager.lootNitro)
        {
            timeNeeded = Time.time + timeUP;
            GameManager.lootNitro = false;
        }

        MoveUpDown();

        RotAround();

        if (transform.position.y <= 0)
        {
            GameManager.trend = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void    MoveUpDown()
    {
        if (timeNeeded - Time.time > 0f)
        {
            //airplane.GetComponent<Rigidbody>().
            //airplane.transform.localEulerAngles = new Vector3(-120f, -0f, -0f);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + deltaHeight, transform.position.z), speedDown * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0, transform.position.z), speedDown * Time.deltaTime);
        }
    }

    void    RotAround()
    {
		if (GameManager.trend)
		{
			airplane.transform.RotateAround(transform.position, Vector3.up, speedAround * Time.deltaTime);
            
        }
        else
        {
            airplane.transform.RotateAround(transform.position, Vector3.down, speedAround * Time.deltaTime);
			
		}
    }
}
