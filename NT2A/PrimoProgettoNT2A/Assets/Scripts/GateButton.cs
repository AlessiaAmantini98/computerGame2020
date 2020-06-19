using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    public Animator animatore;

    private void OnTriggerEnter(Collider other)
    {
        // Quando il player entra nella mia zona, vado a avvertire un animator che un pulsante è stato premuto

        Debug.Log("E' appena entrato un oggetto. L'oggetto si chiama:" + other.gameObject.name);

        animatore.SetTrigger("pulsante");
    }
}
