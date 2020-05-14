using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portale : MonoBehaviour
{
    

    public Portale target;

    public Vector3 offset=Vector3.up;

    public bool stop;

    bool justTeleported = false;

    private void OnTriggerEnter(Collider other)
    {
        // navigazione tra oggetti e componenti
        //this.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = Color.red;

        // se qualcuno non è stato appena trasportato
        if (!justTeleported)
        {
            // ...allora posso trasportarlo

            // avverto il teletrasporto target, che qualcuno è appena arrivato
            target.justTeleported = true;

            // porto l'oggetto nella posizione target, definita dall'oggetto
            other.attachedRigidbody.transform.position = target.transform.position + target.offset;

            // se è stato chiesto di spottare l'oggetto
            if (target.stop)
            {
                // fermo l'oggetto
                other.attachedRigidbody.velocity = Vector3.zero;
            }
        }
        // altrimenti...
        else
        {
            // ...reimposto il flag a false, in modo da riabilitare il teletrasporto alla successiva entrata
            justTeleported = false;
        }


    }
}