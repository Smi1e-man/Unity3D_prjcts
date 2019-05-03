using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    public GameObject pipe;
    public Button RestartButton;
    [HideInInspector]
    public int score;

    void Start()
    {
        StartCoroutine(GeneratePipes());
        RestartButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
            RestartButton.onClick.AddListener(Restart);
    }

    IEnumerator GeneratePipes()
    {
        Vector2 position;

        while (true)
        {
            position = transform.position;
            position.x += 6.0f;
            pipe = Instantiate(pipe, position, Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
    }
}
