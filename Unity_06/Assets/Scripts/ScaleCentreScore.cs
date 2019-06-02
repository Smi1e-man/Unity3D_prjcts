using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCentreScore : MonoBehaviour
{

    int scoreValue;
    Vector3 scaleValue;

    public float deltaScale = 0.1f;
    public float bigScale = 1.24f;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = GameManager.G_score;
        scaleValue = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue < GameManager.G_score)
        {
            scoreValue = GameManager.G_score;
            Scailing();
        }
        if (transform.localScale.x > scaleValue.x)
        {
            transform.localScale -= Vector3.one * deltaScale;
        }
    }

    void    Scailing()
    {
        transform.localScale *= bigScale;
    }
}
