using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallE : MonoBehaviour
{
    public float velocita=0.1f;
    public float velocitaRotazione;
    public float bonusSprint;

    public Vector3 posizioneIniziale;
    public Vector3 orientamentoIniziale;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posizioneIniziale;
        transform.eulerAngles = orientamentoIniziale;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) )
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //Sto andando avanti con doppia velocità
                transform.Translate(new Vector3(0, 0, velocita * bonusSprint  * Time.deltaTime));
            }
            else
            {
                //Sto andando avanti
                transform.Translate(new Vector3(0, 0, velocita * Time.deltaTime));
            }
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, 0-velocita) * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -velocitaRotazione, 0) * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, velocitaRotazione, 0) * Time.deltaTime);
        }

    }
//-------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    //------------------------------------------------------------

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ahia!");
//        Start();
    }

    private void OnTriggerStay(Collider other)
    {
        transform.Rotate(new Vector3(0, 4, 0));
    }

    private void OnTriggerExit(Collider other)
    {
    }

}
