using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FirstPersonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 forw = this.transform.forward;
        forw.y = 0;
        forw.Normalize();

        Vector3 right = this.transform.right;
        right.y = 0;
        right.Normalize();



        this.transform.Translate (forw * y + right * x, Space.World);
    }
}
