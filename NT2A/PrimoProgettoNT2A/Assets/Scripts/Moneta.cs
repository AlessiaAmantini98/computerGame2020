using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour
{
    // rappresenta il valore della moneta (una moneta semplice vale 1, un baule vale 10)
    public int valore;

    public float tempoDistruzione = 5;

    public GameObject effettoDistruzione;


    public void MonetaRaccolta()
    {
        Debug.Log("Funzione Moneta Raccolta avviata");

        /*
         * Metodo 1: trovo l'oggetto
         * 
        // cerca il game manager in scena
        GameManager gameManager = FindObjectOfType<GameManager>();

        // avviso il game manager che sono stata raccolta
        gameManager.MonetaRaccolta(this);
        */


        /* 
         * Metodo 2: Uso del singleton
         * 
        */
        GameManager.instance.MonetaRaccolta(this);

        //Distrugge tutto il game object
        Destroy(gameObject, tempoDistruzione);


        //Instanzia l'effetto di distruzione e posizionandolo dove è la moneta
        GameObject nuovoEffetto;
        nuovoEffetto = Instantiate(effettoDistruzione);
        // copio la mia posizione
        nuovoEffetto.transform.position = transform.position;

    }

}
