using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float Speed;

    void Start()
    {
        Rb = GetComponent <Rigidbody2D>();
    }

    void Update()
    {
        //Face ca nivelul sa mearga in staga
        Rb.velocity = new Vector2(-Speed,0f);
    }

    //Face ca nivelul sa dispara cand ajunge la Spawn
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Untagged")
        {
            Destroy(gameObject);
        }
    }
}
