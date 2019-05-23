using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text Text1;
    public Text Text2;

    int countLoadmain = 0;
    int countLoad2 = 0;
    int delta = 1;

    string key1;
    string key2;

    int check;
    int maxResult = 0;
    public int mainChoice;

    int endCount = GameManager.G_count_text;

    void Start()
    {
        CountLoad();
    }

    public void ClickButtomLoad1()
    {
        check = PlayerPrefs.GetInt(countLoadmain.ToString() + "b");
        key1 = PlayerPrefs.GetString(countLoadmain.ToString() + "a");

        PlayerPrefs.SetInt(countLoadmain.ToString() + "b", ++check);
        PlayerPrefs.SetString(countLoadmain.ToString() + "a", key1);

        PlayerPrefs.Save();

        if (check > maxResult)
        {
            maxResult = check;
            mainChoice = countLoadmain;
        }
        CountLoad();
    }
    public void ClickButtomLoad2()
    {
        check = PlayerPrefs.GetInt(countLoad2.ToString() + "b");
        key2 = PlayerPrefs.GetString(countLoad2.ToString() + "a");

        PlayerPrefs.SetInt(countLoad2.ToString() + "b", ++check);
        PlayerPrefs.SetString(countLoad2.ToString() + "a", key2);

        PlayerPrefs.Save();

        if (check > maxResult)
        {
            maxResult = check;
            mainChoice = countLoad2;
        }
        CountLoad();
    }

    void CountLoad()
    {
		countLoadmain += 1;
        if (countLoadmain + delta <= endCount)
        {
            countLoad2 = countLoadmain + delta;
        }
        else
        {
            delta++;
            countLoadmain = 1;
            if (countLoadmain + delta > endCount)
            {
                GameManager.G_main_choice = mainChoice;
                Application.LoadLevel(2);
            }
            countLoad2 = countLoadmain + delta;

        }
        key1 = countLoadmain.ToString();
        key2 = countLoad2.ToString();
        Debug.Log(key1);
        Debug.Log(key2);
        Load(key1, key2);
    }

    void Load(string key1, string key2)
    {
        if (PlayerPrefs.HasKey(key1 + "a") && PlayerPrefs.HasKey(key2 + "a"))
        {
            Text1.text = PlayerPrefs.GetString(key1 + "a");
            Text2.text = PlayerPrefs.GetString(key2 + "a");
        }
    }
}
