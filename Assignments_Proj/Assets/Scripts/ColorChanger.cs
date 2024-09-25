using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // When the OnLeftClick event occurs, do some funky math using the milliseconds elapsed from the last mouse click to update the color of the object.
    private void OnEnable()
    {
        EventManager.OnRightClick += NewColor;
    }

    private void OnDisable()
    {
        EventManager.OnRightClick -= NewColor;
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
