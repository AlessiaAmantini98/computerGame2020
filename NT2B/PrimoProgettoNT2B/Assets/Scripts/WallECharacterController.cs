using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallECharacterController : MonoBehaviour
{

    public CharacterController controller;

    public float velocita = 7;

    public float gravita = 10;

    public float velocitaRotazione = 180;


    public Animator animatore;

    // Update is called once per frame
    void Update()
    {
        // recupera l'intenzione dell'utente di andare in "avanti". Leggerà le informazioni 
        // del gamepad, del wasd e delle frecce
        // ritorna un valore compreso tra -1 e 1 (1=avanti; -1=indietro; 0 = fermo)
        float avanti = Input.GetAxis("Vertical");

        // andro avanti in proporzione a : il tempo che è passato dal frame precedente,
        // all'intenzione dell'utente e della velocità massima
        // la direzione è l'avanti del trasform dell'oggetto che stiamo muovendo
        controller.Move(transform.forward * Time.deltaTime * avanti * velocita );

        // spingo il personaggio verso il basso
        controller.Move(Vector3.down * Time.deltaTime * gravita);


        // recupera l'intenzione dell'utente di "ruotare". Leggerà le informazioni 
        // del gamepad, del wasd e delle frecce
        // ritorna un valore compreso tra -1 e 1 (1=destra; -1=sinistra; 0 = fermo)
        float rotazione = Input.GetAxis("Horizontal");

        // il controller non comanda le rotazioni, quindi lo facciamo dalla transform
        // girero in proporzione a : il tempo che è passato dal frame precedente,
        // all'intenzione dell'utente e della velocità massima
        transform.Rotate(Vector3.up * Time.deltaTime * rotazione * velocitaRotazione);

        //comunico all'animatore dicendogli se sto correndo o no
        //animatore.SetBool("correndo", avanti > 0.1f);
        //animatore.SetBool("indietro", avanti < -0.1f);

        //Metodo alternativo con condizioni diverse
        animatore.SetFloat("avanti", avanti);
    }

    // Viene chiamato solo dai rigidbody
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision! con " + collision.gameObject.name);
    }

    // può essere chiamato dal Character Controller e dal Rigidbody
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger in " + other.gameObject.name);
    }

    // Chiamato solo dal Character controller
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Collision! con " + hit.gameObject.name);
    }

}
