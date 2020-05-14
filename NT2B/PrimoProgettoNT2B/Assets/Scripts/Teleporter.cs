using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float range=30;

    private void OnTriggerEnter(Collider col)
    {
        col.transform.position = new Vector3(Random.Range(-range, range), col.transform.position.y, Random.Range(-range, range));
    }

}
