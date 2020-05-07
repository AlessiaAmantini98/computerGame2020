using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    // 1 è il default
    public float forza=1;
    public float forzaLevitazione = 200;

    public float velocitaBumber = 1;

    public Vector3 posizioneIniziale;

    public Rigidbody rigidBodyPallina;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posizioneIniziale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBodyPallina.AddForce(Vector3.forward * forza);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidBodyPallina.AddForce(-Vector3.forward * forza);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidBodyPallina.AddForce(Vector3.right * forza);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBodyPallina.AddForce(-Vector3.right * forza);
        }
    }

    // viene chiamato al primo contatto con un oggetto solido
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CONTATTO CON:" + collision.gameObject.name );

        if (collision.gameObject.name=="Bumber")
        {
            Debug.Log("Contatto con bumber");
            rigidBodyPallina.velocity = Vector3.up* velocitaBumber;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("DENTRO L'AREA:" + other.gameObject.name);

        if (other.gameObject.name=="Area (Logica)")
        {
            rigidBodyPallina.AddForce(Vector3.up * forzaLevitazione);
        }
    }
}
