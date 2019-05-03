using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesHelper : MonoBehaviour
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 position = transform.position;
        position.y = Random.Range(-0.3F, 1.8F);
        transform.position = position;
        Destroy(gameObject,6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
