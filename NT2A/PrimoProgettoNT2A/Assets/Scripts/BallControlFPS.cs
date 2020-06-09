using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlFPS : MonoBehaviour
{
    // 1 è il default
    public float forza = 1;

    public Rigidbody rigidBodyPallina;


    // Update is called once per frame
    void Update()
    {
        float destra = Input.GetAxis("Horizontal");
        float avanti = Input.GetAxis("Vertical");

        rigidBodyPallina.AddForce(transform.forward * forza * avanti);
        rigidBodyPallina.AddForce(transform.right * forza * destra);

        Debug.LogFormat(" destra:{0} avanti:{1} ", destra, avanti);

    }
}
