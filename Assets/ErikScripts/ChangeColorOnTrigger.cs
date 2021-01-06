using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{
    private Renderer _colorChange;

    private void OnTriggerEnter(Collider other)
    {
        Color randomlySelectedColor = GetRandomColorWithAlpha();
        _colorChange = GetComponent<Renderer>();
        _colorChange.material.color = randomlySelectedColor;
    }

    private Color GetRandomColorWithAlpha()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            .025f);
    }
}

