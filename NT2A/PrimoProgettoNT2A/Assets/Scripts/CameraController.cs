using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float dump = 0.15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Guarda il personaggio target
        this.transform.LookAt(target);


        // la posizione target è uguale alla posizione dell'oggetto più un certo offset definito
        Vector3 posizioneTarget = target.position + offset;

        this.transform.position =  Vector3.MoveTowards(transform.position, posizioneTarget , dump) ;
    }
}
