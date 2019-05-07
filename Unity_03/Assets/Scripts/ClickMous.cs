using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMous : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.GetComponent<IBlocks>().Click();

    }
}
