using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterText : MonoBehaviour
{
    public InputField inputF;
    public string inputText;
    public GameObject Panel;

    // Update is called once per frame
    void Update()
    {
        inputText = inputF.textComponent.text;
    }
    public void SaveInput()
    {
        Panel.SetActive(false);
    }
}
