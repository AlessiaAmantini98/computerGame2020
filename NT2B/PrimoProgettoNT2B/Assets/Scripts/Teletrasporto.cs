using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletrasporto : MonoBehaviour
{

    public Transform destinazione;

    private void OnTriggerEnter(Collider other)
    {

        other.attachedRigidbody.transform.position = destinazione.transform.position ;
    }

}
