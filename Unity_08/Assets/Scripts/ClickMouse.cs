using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickMouse : MonoBehaviour
{
    
    Rigidbody rb;

    bool click = false;
    bool stayCentre = false;


    Vector3 posTarget;

    //public Transform target;

	private void Awake()
	{
        rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start()
    {
        //rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (click)
        {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, 25f * Time.deltaTime);
            if (Mathf.Abs(transform.position.x) < 1.5f && Mathf.Abs(transform.position.z) < 1.5f)
            {
                Debug.Log("Stay");
                rb.velocity = Vector3.zero;
				stayCentre = true;
				click = false;

            }
        }

        if (stayCentre)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 15f);
        }

        if (Input.GetMouseButtonDown(0) && stayCentre)
        {
            Debug.Log("Click");
            stayCentre = false;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                rb.mass = 1;
                rb.AddForce(hit.point * 300f);
            }
        }

        if (transform.position.x == 0f && transform.position.z == 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    private void OnMouseUp()
    {
        click = true;
	}
}
