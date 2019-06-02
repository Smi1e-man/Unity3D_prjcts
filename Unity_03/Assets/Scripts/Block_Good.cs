using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Good : MonoBehaviour, IBlocks
{
    ParticleSystem particleSystem;
    ParticleSystemRenderer particleSystemRenderer;

    Material Good_mtrl;

    void Awake()
    {
        particleSystem = FindObjectOfType<ParticleSystem>();
        particleSystem.Stop();

		particleSystemRenderer = FindObjectOfType<ParticleSystemRenderer>();
        Good_mtrl = Resources.Load<Material>("Material/Boom_Good");
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
        particleSystemRenderer.material = Good_mtrl;
        particleSystem.Emit(15);
    }
    public void Swipe()
    {
        //Destroy(gameObject);

    }
    public void Crush()
    {
        GameManager.G_score++;
        particleSystem.Clear();
        particleSystem.gameObject.transform.position = gameObject.transform.position;
        Destroy(gameObject);
        particleSystemRenderer.material = Good_mtrl;
        particleSystem.Emit(5);
    }
}
