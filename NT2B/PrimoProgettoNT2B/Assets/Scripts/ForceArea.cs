using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceArea : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float forzaLevitazione = 10;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("SONO NELL'AREA: " + other.gameObject.name);

        other.attachedRigidbody.AddForce( direction * forzaLevitazione );
    }
    
}
