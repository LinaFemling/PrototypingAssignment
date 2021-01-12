using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizeOnTrigger : MonoBehaviour
{
    public GameObject Ring;
    public GameObject RingLift;
    private Transform _sizeChange;
    private Collider _ring;
    private Collider _ringLift;

    private void Start()
    {

        //Ring = _ring;
        _ring = Ring.GetComponent<MeshCollider>();
        _ringLift = RingLift.GetComponent<BoxCollider>();
    }
    private void Awake()
    {
       
        //Ring = _ring;
        //_ring = Ring.GetComponent<MeshCollider>;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == _ring)
        {
            //Ring.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            _sizeChange = GetComponent<Transform>();
            _sizeChange.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        else if (other == _ringLift)
        {
            _sizeChange = GetComponent<Transform>();
            _sizeChange.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
