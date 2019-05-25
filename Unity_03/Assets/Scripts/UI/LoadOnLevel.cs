using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnLevel : MonoBehaviour
{

	IEnumerator Load()
	{
		yield return new WaitForSeconds(0.7f);
        loadlevel(1);
	}
    void loadlevel(int level)
    {
        Application.LoadLevel(level);
    }
}
