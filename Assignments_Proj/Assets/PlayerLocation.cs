using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    // When the "OnPDown" event occurs, print the current player location to the debug console.
    private void OnEnable()
    {
        EventManager.OnPDown += PrintPlayerPosition;
    }
    private void OnDisable()
    {
        EventManager.OnPDown -= PrintPlayerPosition;
    }
    private void PrintPlayerPosition()
    {
        Vector3 playerPos = GetPlayerPosition();
        Debug.Log("Player is currently located at X: " + playerPos.x + ", Y: " + playerPos.y + ", and Z: " + playerPos.z);
    }
    private Vector3 GetPlayerPosition()
    {
        return GetComponent<Transform>().position;
    }
}
