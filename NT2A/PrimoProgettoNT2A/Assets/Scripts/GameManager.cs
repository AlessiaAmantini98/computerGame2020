using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // creo una variabile statica (che esiste sempre)
    // che rappresenta la copia unica dell'oggetto in scena
    public static GameManager instance;

    private void Awake()
    {
        // riempio la variabile statica con me stesso,
        // così tutti sapranno che devono parlare con me
        // Questa tecnica si chiama "Singleton"
        instance = this;
    }


    public int moneteDaRaccogliere = 15;

    int moneteRaccolte = 0;


    // Tiene traccia delle monete raccolte, in modo da controllare lo stato del gioco
    public void MonetaRaccolta(Moneta moneta)
    {
        // incremento il valore delle monete raccolte
        moneteRaccolte += moneta.valore;

        // controllo se ho vinto
        if (moneteRaccolte>=moneteDaRaccogliere)
        {
            Debug.Log("HAI VINTO!");
        }
        else
        {
            Debug.LogFormat("Hai raccolto fin'ora: {0} monete", moneteRaccolte);
        }
    }

}
