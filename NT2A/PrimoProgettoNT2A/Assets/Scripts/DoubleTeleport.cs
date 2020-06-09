using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTeleport : MonoBehaviour
{
    public DoubleTeleport otherPortal;

    public AudioSource soundFx;
    public ParticleSystem effetto;

    bool justTeleported=false;

    public Vector3 offset = Vector3.up;

    public bool stopVelocity = false;

    // Soluzione migliore, mi faccio dire cosa devo colorare 
    // e di che colore
    public MeshRenderer renderToColorized;
    public Color targetColor = Color.red;

    private void OnTriggerEnter(Collider other)
    {
        /* Soluzion A --------
        // Recupero l'oggeto figlio di questa transform (0=primo)
        // (L'oggetto cubo)
        Transform figlio = this.gameObject.transform.GetChild(0);
        // Recupero il suo componente MeshRenderer
        MeshRenderer render = figlio.GetComponent<MeshRenderer>();
        render.material.color = Color.red;
        */

        renderToColorized.material.color = targetColor;

        // dico all'altro portale che qualcuno si è appena teletrasportato, quindi
        // di non riteletraposrtarlo indietro
        if (!justTeleported)
        {
            otherPortal.soundFx.Play();
            otherPortal.effetto.Play();

            otherPortal.justTeleported = true; // ignora la prossima entrata
            other.transform.position = otherPortal.transform.position + otherPortal.offset;

            // se il teletrasporto mi chiede di stoppare l'oggetto lo faccio
            if (otherPortal.stopVelocity)
            {
                // prendo il rigidbody dell'ogetto che è entrato
                // e imposto la sua velocità a zero
                other.attachedRigidbody.velocity = Vector3.zero;
            }
        }

        //Azzero la situazione
        justTeleported = false;
    }

}
