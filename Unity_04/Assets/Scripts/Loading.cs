using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text Text1;
    public Text Text2;

    void Start()
    {
        Load();
    }

    void Load()
    {
        //string key = GameManager.G_count_text.ToString();
        string key1 = "1";
        string key2 = "2";
        if (PlayerPrefs.HasKey(key1 + "a") && PlayerPrefs.HasKey(key2 + "a"))
        {
            Text1.text = PlayerPrefs.GetString(key1 + "a");
            Text2.text = PlayerPrefs.GetString(key2 + "a");
        }
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        //Debug.Log(key);
    }
}
