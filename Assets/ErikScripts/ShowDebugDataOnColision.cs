using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDebugDataOnColision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Impacted at" + collision.contacts[0].point);

        float rayDrawDistance = 5f;

        Debug.DrawRay(
            collision.contacts[0].point,
            collision.contacts[0].normal * rayDrawDistance,
            Color.red,
            1f);
    }
}
