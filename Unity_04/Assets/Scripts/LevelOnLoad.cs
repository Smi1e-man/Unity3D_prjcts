using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnLoad : MonoBehaviour
{
    public int level;

    public void LevelNeeded()
    {
        if (GameManager.G_count_text > 2)
            Application.LoadLevel(level);
    }
}
