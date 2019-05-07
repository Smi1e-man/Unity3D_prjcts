using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnLevel : MonoBehaviour
{
    public void loadlevel(int level)
    {
        Application.LoadLevel(level);
    }
}
