using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{

    public Animator animatore;

    public string trigger;

    private void OnTriggerEnter(Collider other)
    {
        animatore.SetTrigger(trigger);
    }

}
