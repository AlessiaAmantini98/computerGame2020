using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Wall_E : MonoBehaviour
{
    public float velocita;
    public float velocitaRotazione;

    public Vector3 posizioneIniziale;
    public Vector3 orientamentoIniziale;

    // Start is called before the first frame update
    void Start()
    {
        // vado nella zona (componente) transform
        // e metto nella posizione dei NUOVI valori
        // -> 0,0,0
        transform.position = posizioneIniziale;
        
        transform.eulerAngles = orientamentoIniziale;

        Debug.Log("Hello!");
    }

    

    // Update is called once per frame
    void Update()
    {

        if ( Input.GetKey(KeyCode.W)  )
        {
            transform.Translate( new Vector3(0, 0 , velocita ) );
        }
       

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, (0-velocita)  ));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, velocitaRotazione, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -velocitaRotazione, 0));
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ahia!");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ahia!");
    }

}
