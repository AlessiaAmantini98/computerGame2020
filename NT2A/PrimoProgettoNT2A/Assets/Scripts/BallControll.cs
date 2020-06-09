using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    // 1 è il default
    public float forza=1;
    public float forzaSalto=3;

    public Vector3 posizioneIniziale;

    public Rigidbody rigidBodyPallina;

    public AudioSource rotolamento;
    public float proporzioneVolumeRotolamento = 0.1f;
    
    bool onFloor = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posizioneIniziale;
    }

    // Update is called once per frame
    void Update()
    {
        // se sono sul pavimento, allora il volume del rotolamento è proporzionale alla velocità
        if (onFloor)
        {
            rotolamento.volume = rigidBodyPallina.velocity.magnitude * proporzioneVolumeRotolamento;
            rotolamento.pitch = 0.6f + rigidBodyPallina.velocity.magnitude * proporzioneVolumeRotolamento;
        }
        // altrimenti il volume è zero
        else rotolamento.volume = 0;

        if (Input.GetKey(KeyCode.W))
        {
            rigidBodyPallina.AddForce(Vector3.forward * forza);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidBodyPallina.AddForce(Vector3.back * forza);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidBodyPallina.AddForce(Vector3.right * forza);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBodyPallina.AddForce(Vector3.left * forza);
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        onFloor = true;

        if (Input.GetKey(KeyCode.Space))
        {
            rigidBodyPallina.AddForce(Vector3.up * forzaSalto);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        onFloor = false;
    }

}
