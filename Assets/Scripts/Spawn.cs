using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;

    int Rand = 1;
    int Prev;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other != null)
        {
            Prev = Rand;
            Rand = Random.Range(1, 7);
            while(Rand == Prev)
            {
                Rand = Random.Range(1, 7);
            }
            
            if(Rand == 1)
            {
                Instantiate(Level1, transform.position, transform.rotation);
            }

            if (Rand == 2)
            {
                Instantiate(Level2, transform.position, transform.rotation);
            }

            if (Rand == 3)
            {
                Instantiate(Level3, transform.position, transform.rotation);
            }

            if (Rand == 4)
            {
                Instantiate(Level4, transform.position, transform.rotation);
            }

            if (Rand == 5)
            {
                Instantiate(Level5, transform.position, transform.rotation);
            }

            if (Rand == 6)
            {
                Instantiate(Level6, transform.position, transform.rotation);
            }
        }
    }
}
