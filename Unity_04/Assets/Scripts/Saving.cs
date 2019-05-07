using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saving : MonoBehaviour
{
    public Text Text;
    public GameObject EnterText;
    string text;

    public void SaveText()
    {
        text = EnterText.GetComponent<EnterText>().inputText;
        if (text != "")
        {
			Text.text += "\n" + text;
            GameManager.G_count_text++;
            string key = GameManager.G_count_text.ToString();
            SaveData(text, key);
        }
    }
    void SaveData(string text, string key)
    {
        PlayerPrefs.SetString(key + "a", text);
        PlayerPrefs.Save();
    }
}
