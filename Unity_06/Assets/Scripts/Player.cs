using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject playerRotate;

    // Update is called once per frame

    Vector3 rotateDelta = new Vector3(0, 0, 60);

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerRotate.transform.eulerAngles += rotateDelta; 
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerRotate.transform.eulerAngles -= rotateDelta;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.G_score = 0;
    }
}
