using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector3 posizioneIniziale = new Vector3(0, 2, 0);

    public float forza;

    public Rigidbody rbPallina;


    public float forzaSalto = 100;

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

    private void OnCollisionStay(Collision collision)
    {
        //Se premo il tasto Spazio
        if (Input.GetKey(KeyCode.Space))
        {
            //Allora do una forza verso l'alto
            rbPallina.AddForce(Vector3.up * forzaSalto);
        }
    }



}