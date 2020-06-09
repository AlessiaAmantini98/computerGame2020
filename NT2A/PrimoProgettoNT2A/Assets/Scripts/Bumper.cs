using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 direction;
    public float velocity;

    public AudioSource soundFx;

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.velocity = direction * velocity;

        soundFx.Play();
    }


}
