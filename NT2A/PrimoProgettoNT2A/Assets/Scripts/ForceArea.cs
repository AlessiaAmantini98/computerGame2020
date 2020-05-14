using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceArea : MonoBehaviour
{
    public Vector3 direction=Vector3.up;
    public float force = 10;

    public bool onlyForPlayer = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Qualcuno è entrato nella mia area: " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Qualcuno è dentro la mia area: " + other.gameObject.name);

        // se l'area influenza solo il player
        if (onlyForPlayer)
        {
            // darò la forza solo se l'oggetto che entrato è un player
            if (other.gameObject.CompareTag("Player"))
            {
                // è il player, quindi aggiungo la forza
                other.attachedRigidbody.AddForce(direction * force, ForceMode.VelocityChange);
            }
        }
        // Se il campo di forza è per tutti..
        else
        {
            //... aggiungi la forza
            other.attachedRigidbody.AddForce(direction * force, ForceMode.VelocityChange);
        }

        
    }
}
