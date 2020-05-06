using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallETesta : MonoBehaviour
{
    public Vector3 velocitaRotazione;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(velocitaRotazione);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-velocitaRotazione);
        }

    }
}
