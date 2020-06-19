using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GenericButton : MonoBehaviour
{
    // Un evento di unity. Non so cosè, qualcuno lo impostarà sull'editor
    public UnityEvent evento;

    private void OnTriggerEnter(Collider other)
    {
        // se ho qualche evento da fare, lo invoco
        if (evento != null) evento.Invoke();
    }
}
