using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 direction;
    public float velocity;


    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.velocity = direction * velocity;
    }


}
