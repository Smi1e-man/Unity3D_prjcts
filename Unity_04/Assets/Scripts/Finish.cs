using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text Text;

    void Start()
    {
        Text.text = PlayerPrefs.GetString(GameManager.G_main_choice.ToString() + "a");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }

}
