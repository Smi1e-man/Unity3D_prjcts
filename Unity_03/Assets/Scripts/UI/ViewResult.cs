using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewResult : MonoBehaviour
{
    public Text Name;


	private void Update()
	{
        if (PlayerPrefs.HasKey("Chill"))
        {
            Name.text = "Score" + PlayerPrefs.GetInt("Chill").ToString();
        }
        else
        {
            Name.text = "Good Bad Bomb";
        }
	}
}
