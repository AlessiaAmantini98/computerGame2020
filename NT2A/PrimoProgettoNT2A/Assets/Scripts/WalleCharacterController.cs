using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalleCharacterController : MonoBehaviour
{

    public CharacterController controller;

    public float velocita = 7; //metri al secondi
    public float velocitaRotazione = 180; // gradi al secondo

    public float gravity = 10;


    public Animator animatore;

    // Update is called once per frame
    void Update()
    {
        // torna un numero compreso tra -1 e 1 in funzione dell'input dell'utente (intenzione di andare avanti)
        // riconosce sia le frecce che il gamepad
        float avanti = Input.GetAxis("Vertical"); 

        // mi muovo in avanti, ma in modo proporzionale al tempo passato dal frame precedente, a quanto l'utente 
        // vuole andare avanti e anche in base alla velocità massima
        controller.Move(transform.forward * Time.deltaTime * avanti * velocita);


        // gestisto la gravità muovendo il mio personaggio verso il basso
        controller.Move(Vector3.down * Time.deltaTime * gravity);


        // torna un numero compreso tra -1 e 1 in funzione dell'input dell'utente (intenzione di ruotare)
        // riconosce sia le frecce che il gamepad
        float ruotare = Input.GetAxis("Horizontal");

        // ruoto il personaggio sull'asse verticale, ma in modo proporzionale al tempo passato dal frame precedente
        // , a di quanto l'utente vuole ruotare e anche in base alla velocità di rotazione massima
        transform.Rotate(Vector3.up * Time.deltaTime * ruotare * velocitaRotazione);


        // Comunica all'animatore cosa sta succedendo in modo da allineare le animazioni al movimento
        animatore.SetBool("correndo", avanti > 0.1f);
        animatore.SetBool("indietro", avanti < -0.1f);

    }

    // !!!!!  questo non funziona !!!!!!!
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collisione Con:" + collision.gameObject.name);
    }

    // Posso usare i trigger ma solo se ho aggiunto un rigidbody cinematico
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Con:" + other.gameObject.name);
    }

    // In caso di character controller le collisioni vengono catturate con questo metodo
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("Collisione Con:" + hit.gameObject.name);
    }
}
