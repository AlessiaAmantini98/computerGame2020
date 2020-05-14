using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{   
    //public Rigidbody rbPallina;
    //public Vector3 direction = Vector3.up;
    // public float forzaLievitazione = 10;
    public Vector3 arrivo = new Vector3(0, 0.6f, 0); // DESTINAZIONE D'ARRIVO 
    
    private void OnTriggerStay (Collider other)
    {
        //Debug.Log("SONO NELL'AREA: " + other.gameObject.name);

        //other.attachedRigidbody.AddForce(Vector3.up * forzaLievitazione);  FA LIEVITARE CHI SALE SOPRA

        other.attachedRigidbody.transform.position = arrivo; // FA TELETRASPORTARE CHI SALE SOPRA
    }
  
}
