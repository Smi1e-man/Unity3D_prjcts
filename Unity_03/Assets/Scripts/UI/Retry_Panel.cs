using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retry_Panel : MonoBehaviour
{
    public GameObject panel;

    public void ViewPanel()
    {
        panel.SetActive(true);
    }

    public void RetryLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
        GameManager.Play_game();
    }
}
