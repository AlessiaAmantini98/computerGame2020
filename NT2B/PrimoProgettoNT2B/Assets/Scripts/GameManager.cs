using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Questa variabile esisterà una sola volta in memoria
    // sarà accessibile da tutti nella forma GameManager.instanza
    public static GameManager instanza;


    private void Awake()
    {
        // in questa variable accessibile a tutti, registro me stesso
        // questo sistema di chiama "SINGLETON"
        instanza = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // E' il valore obiettivo del livello, può essere cambiato da livello 
    // a livello in base alla scena
    public int valoreObiettivo = 15;
    
    // tiene traccia di quanto ho raccolto fin'ora. E sul game manager
    // che è univoco in scena, quindi ne ho solo una versione
    int valoreAttuale = 0;

    // Deve essere chiamato ogni volta che raccolgo un oggetto di valore
    public void RaccoltoOggetto(Moneta oggetoRaccolto)
    {
        // aumento il valore attuale
        valoreAttuale = valoreAttuale + oggetoRaccolto.valore;
        Debug.LogFormat("Valore attuale:{0}", valoreAttuale);

        // controllo se ho vinto
        if (valoreAttuale>=valoreObiettivo)
        {
            // Hai vinto!
            Debug.Log("Hai vinto!!!");
        }
    }

}
