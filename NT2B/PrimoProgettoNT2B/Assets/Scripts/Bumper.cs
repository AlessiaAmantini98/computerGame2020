using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float velocitaBump = 4;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("BUMPER CONTATTO CON:" + collision.gameObject.name);

        collision.rigidbody.velocity = direction * velocitaBump;
    }

}
