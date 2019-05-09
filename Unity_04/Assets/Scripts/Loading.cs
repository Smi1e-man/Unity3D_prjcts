using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text Text1;
    public Text Text2;

    public int countLoadmain = 1;
    int countLoad2 = 2;

    string key1;
    string key2;

    int check;
    int maxResult = 0;
    public int mainChoice;

    int endCount = GameManager.G_count_text;

    void Start()
    {
        Load(countLoadmain.ToString(), countLoad2.ToString());
    }

    public void ClickButtomLoad1()
    {
        check = PlayerPrefs.GetInt(countLoadmain.ToString() + "a");
        key1 = PlayerPrefs.GetString(countLoadmain.ToString() + "a");
        PlayerPrefs.SetInt(countLoadmain.ToString() + "a", ++check);
        PlayerPrefs.SetString(countLoadmain.ToString() + "a", key1);
        PlayerPrefs.Save();

        if (check > maxResult)
        {
            maxResult = check;
            mainChoice = countLoadmain;
        }

        countLoad2++;
        CountLoad();
    }
    public void ClickButtomLoad2()
    {
        check = PlayerPrefs.GetInt(countLoad2.ToString() + "a");
        key2 = PlayerPrefs.GetString(countLoad2.ToString() + "a");
        PlayerPrefs.SetInt(countLoad2.ToString() + "a", ++check);
        PlayerPrefs.SetString(countLoad2.ToString() + "a", key2);
        PlayerPrefs.Save();

        if (check > maxResult)
        {
            maxResult = check;
            mainChoice = countLoad2;
        }

        countLoad2++;
        CountLoad();
    }

    void CountLoad()
    {
        if (countLoadmain < endCount)
        {
            key1 = countLoadmain.ToString();
            key2 = countLoad2.ToString();
            Load(key1, key2);
            if (countLoad2 == endCount)
            {
                countLoadmain++;
                countLoad2 = countLoadmain;
            }
        }
        else
        {
            GameManager.G_main_choice = mainChoice;
            Application.LoadLevel(2);

            //PlayerPrefs.DeleteAll();
            //PlayerPrefs.Save();
        }
    }

    void Load(string key1, string key2)
    {
        //string key = GameManager.G_count_text.ToString();
        //string key1 = "1";
        //string key2 = "2";
        if (PlayerPrefs.HasKey(key1 + "a") && PlayerPrefs.HasKey(key2 + "a"))
        {
            Text1.text = PlayerPrefs.GetString(key1 + "a");
            Text2.text = PlayerPrefs.GetString(key2 + "a");
            //Debug.Log("TEXT_2" + Text2.text);
        }
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.Save();
        //Debug.Log(key);
    }
}
