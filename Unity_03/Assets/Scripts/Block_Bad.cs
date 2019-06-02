using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Bad : MonoBehaviour, IBlocks
{
    ParticleSystem particleSystem;
    ParticleSystemRenderer particleSystemRenderer;

    Material Bad_mtrl;

    void Awake()
    {
        particleSystem = FindObjectOfType<ParticleSystem>();
        particleSystem.Stop();

		particleSystemRenderer = FindObjectOfType<ParticleSystemRenderer>();
        Bad_mtrl = Resources.Load<Material>("Material/Boom_Bad");
    }
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        ;
    }
    public void Click()
    {
        particleSystem.Clear();
        particleSystem.gameObject.transform.position = gameObject.transform.position;
        Destroy(gameObject);
        particleSystemRenderer.material = Bad_mtrl;
        particleSystem.Emit(15);
    }
    public void Swipe()
    {
        //Destroy(gameObject);

    }
    public void Crush()
    {
        GameManager.G_score--;
        if (GameManager.G_score < 0)
            GameManager.G_score = 0;
        particleSystem.Clear();
        particleSystem.gameObject.transform.position = gameObject.transform.position;
        Destroy(gameObject);
        particleSystemRenderer.material = Bad_mtrl;
        particleSystem.Emit(7);
    }
}
