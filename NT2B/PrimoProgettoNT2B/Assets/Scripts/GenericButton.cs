using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GenericButton : MonoBehaviour
{

    // oggetto che permette di configurare
    // lato unity, una o più cose da fare 
    // al momento dell'invocazione di questo evento
    public UnityEvent evento;

    private void OnTriggerEnter(Collider other)
    {
        // se è stato definito cosa fare
        // allora avvio quello da fare
        if (evento != null) evento.Invoke();
    }

}
