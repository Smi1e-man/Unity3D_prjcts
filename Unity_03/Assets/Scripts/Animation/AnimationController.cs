using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animation anim;

	private void Awake()
	{
        anim = GetComponent<Animation>();
        anim.Play("Block_Good");
	}
}
