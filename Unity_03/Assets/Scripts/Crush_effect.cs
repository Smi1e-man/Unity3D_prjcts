using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush_effect : MonoBehaviour
{
    public GameObject block;

    ParticleSystem particleSystem;

	private void Awake()
	{
        particleSystem = FindObjectOfType<ParticleSystem>();
        particleSystem.Stop();
	}

	public void Boom_effect()
    {
        Destroy(block);
        particleSystem.Emit(30);
    }
}
