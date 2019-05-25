using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    public static int G_score = 0;

    public static int G_move_game = 1;

    public static void     Stop_game()
    {
        G_move_game = 0;
        GameObject.FindGameObjectWithTag("Manager").GetComponent<Retry_Panel>().ViewPanel();
    }

    public static void Play_game()
    {
        G_move_game = 1;
        if (PlayerPrefs.HasKey("Chill"))
        {
            if (G_score > PlayerPrefs.GetInt("Chill"))
            {
				PlayerPrefs.SetInt("Chill", G_score);
				PlayerPrefs.Save();            
            }
        }
        G_score = 0;
    }
}
