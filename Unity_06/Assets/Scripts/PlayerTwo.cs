using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwo : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 heightDelta = new Vector2(0f, 2.5f);

	private void Awake()
	{
        rb = GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y > 2.5f)
        {
            rb.velocity = heightDelta;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.G_score = 0;
    }
}
