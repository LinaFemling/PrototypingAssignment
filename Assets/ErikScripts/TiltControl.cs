using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControl : MonoBehaviour
{
 [SerializeField] private float _tiltSpeed = 5f;

    private void Update()
    {
        float horizontal = -Input.GetAxis("Horizontal");
        float vertical = -Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, horizontal * Time.deltaTime * _tiltSpeed);
        transform.Rotate(Vector3.left, vertical * Time.deltaTime * _tiltSpeed);
    }
}
