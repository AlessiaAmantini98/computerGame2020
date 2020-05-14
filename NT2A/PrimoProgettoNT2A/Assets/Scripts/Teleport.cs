using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform transport2;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Qualcuno è nel teletrasporto:" + other.gameObject.name);

        

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Qualcuno è entrato nel teletrasporto:"+ other.gameObject.name);
        
        other.transform.position = transport2.position;
    } 
    


}
