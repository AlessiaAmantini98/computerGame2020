using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceArea : MonoBehaviour
{
    public Vector3 direction=Vector3.up;
    public float force = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Qualcuno è entrato nella mia area: " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Qualcuno è dentro la mia area: " + other.gameObject.name);

        other.attachedRigidbody.AddForce(direction * force, ForceMode.VelocityChange);
    }
}
