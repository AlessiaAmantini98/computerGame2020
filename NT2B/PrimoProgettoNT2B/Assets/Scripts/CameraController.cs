using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float bumping = 0.05f;

    // Update is called once per frame
    void LateUpdate()
    {
        // la transform della camera (this.transform) deve guardare verso il target
        //this.transform.LookAt(target);


        // la mia posizione è uguale alla posizione del target più un certo offset di distanza
        //this.transform.position = target.position + offset;

        // muovo la mia posizione corrente, verso quella di destinazione, ma facendo
        // un massimo di passi alla volta
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position + offset, bumping);
    }
}
