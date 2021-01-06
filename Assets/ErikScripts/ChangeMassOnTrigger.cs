using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMassOnTrigger : MonoBehaviour
{
    private Rigidbody _massChange;
    private void OnTriggerEnter(Collider other)
    {
        _massChange = GetComponent<Rigidbody>();
        _massChange.mass = 3f;
    }

    ///private  newMasschange()
       // return
   
}
