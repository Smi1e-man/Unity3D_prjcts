using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHelper : MonoBehaviour
{
    public float force;
    private Rigidbody2D rigidbody;
    private GameHelper gameHelper;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        gameHelper = Camera.main.GetComponent<GameHelper>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
        }
        rigidbody.MoveRotation(rigidbody.velocity.y * 2.0f);
    }

	void OnCollisionEnter2D(Collision2D collision)
	{
        gameHelper.RestartButton.gameObject.SetActive(true);
        //gameHelper.RestartButton.onClick.AddListener(gameHelper.Restart);
        Time.timeScale = 0.0f;
	}
	void OnTriggerExit2D(Collider2D other)
	{
        gameHelper.score++;
        Debug.Log(gameHelper.score);
	}
}
