using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour
{
    public int valore;

    public float tempoDistruzione = 5;

    public GameObject effettoDistruzione;

    

    public void MonetaRaccolta()
    {

        Debug.Log("Moneta raccolta");

        // Opzione 1: Cerco il game manager sulla base del tipo
        //GameManager gameManager = FindObjectOfType<GameManager>();

        // Opzione 2: Uso il singleton per arrivare subito al gamemanager
        GameManager gameManager = GameManager.instanza;

        gameManager.RaccoltoOggetto(this);

        // Distrugge l'oggetto (game object) aspettando un po' di tempo
        Destroy(gameObject, tempoDistruzione);

        // prepara nella posizione dell'oggetto stesso,
        // una copia di un effetto particellare, in modo da 
        // rendere la scomparsa della moneta più piacevole.
        GameObject nuovoOggetto;
        nuovoOggetto = Instantiate(effettoDistruzione);
        nuovoOggetto.transform.position = this.transform.position;
    }


}
