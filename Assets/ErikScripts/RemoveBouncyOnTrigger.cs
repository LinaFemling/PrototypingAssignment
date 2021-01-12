using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBouncyOnTrigger : MonoBehaviour
{
    public GameObject Ring;
    public GameObject ReturnToBounce;
    private SphereCollider _removeBounce;

    private Collider _ring;
    private Collider _returnToBounce;


    private void Start()
    {
        _ring = Ring.GetComponent<MeshCollider>();
        _returnToBounce = ReturnToBounce.GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (other == _ring)
        {
            _removeBounce = GetComponent<SphereCollider>();
            _removeBounce.material.bounciness = 0f;
        }
        else if (other == _returnToBounce)
        {
            _removeBounce = GetComponent<SphereCollider>();
            _removeBounce.material.bounciness = 1f;
        }
    }
}
