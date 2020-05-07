using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector3 posizioneIniziale = new Vector3(0, 2, 0);

    public float forza;
    public float forzaLevitazione = 10;
    public Rigidbody rbPallina;

    public float velocitaBumper=5;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posizioneIniziale;
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        // se sto premento il tasto W
        if (Input.GetKey(KeyCode.W))
        {
            rbPallina.AddForce(Vector3.forward * forza);
        }
        // se sto premento il tasto S
        if (Input.GetKey(KeyCode.S))
        {
            rbPallina.AddForce(Vector3.back * forza);
        }

        // se sto premento il tasto D
        if (Input.GetKey(KeyCode.D))
        {
            rbPallina.AddForce(Vector3.right * forza);
        }
        // se sto premento il tasto A
        if (Input.GetKey(KeyCode.A))
        {
            rbPallina.AddForce(Vector3.left * forza);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CONTATTO CON:" + collision.gameObject.name  );

        if (collision.gameObject.name == "Bumper")
        {
            Debug.Log("Bumper!");
            rbPallina.velocity = Vector3.up * velocitaBumper;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("USCITA DA:" + collision.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        rbPallina.AddForce(Vector3.up * forzaLevitazione);
    }
}