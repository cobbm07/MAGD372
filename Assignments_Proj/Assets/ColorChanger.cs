using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnLeftClick += NewColor;
    }

    private void OnDisable()
    {
        EventManager.OnLeftClick -= NewColor;
    }

    void NewColor(float f)
    {
        float newR = (f % 17) * 58 / 1000;
        float newG = Mathf.Min(f, 1000) / 1000;
        float newB = Random.value;
        Color newCol = new Color(newR, newG, newB);
        Debug.Log("Changing arch color to R: " + newR + ", G: " + newG + ", B: " + newB + "!");
        GetComponent<Renderer>().material.color = newCol;
    }
}
