using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerFPS : MonoBehaviour
{
    public Rigidbody rbPallina;
    public Transform mainCamera;

    public float forza;


    // Update is called once per frame
    void Update()
    {
        float avanti = Input.GetAxis("Vertical");
        float destra = Input.GetAxis("Horizontal");

        Debug.LogFormat("avanti:{0} destra:{1} ", avanti,destra);

        rbPallina.AddForce(mainCamera.forward * forza * avanti);
        rbPallina.AddForce(mainCamera.right * forza * destra);
        
    }
}
