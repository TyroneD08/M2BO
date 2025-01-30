using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    void Update()
    {
        // Laat de coin continu roteren
        transform.Rotate(0, 360 * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Controleer of de speler de coin raakt
        if (collision.gameObject.CompareTag("player"))
        {
            // Verwijder het object (coin)
            Destroy(gameObject);
        }
        void OnCollisionEnter(Collision collision)
{
    Debug.Log("Collision detected with: " + collision.gameObject.name);

    if (collision.gameObject.CompareTag("player"))
    {
        Debug.Log("Coin picked up!");
        Destroy(gameObject);
    }
}

       
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("player"))
            {
                Debug.Log("Coin picked up!");
                Destroy(gameObject);
            }
        }


    }
}
