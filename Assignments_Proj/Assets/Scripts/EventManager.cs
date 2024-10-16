using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // Event #1 occurs when the right mouse button is pressed.
    // The event sends the subscriber(s) a float representing the time passed since the last mouse click.
    public delegate void RClickAction(float timeSinceClick);
    public static event RClickAction OnRightClick;

    public delegate void LClickAction();
    public static event LClickAction OnLeftClick;

    // Event #2 occurs when the "P" key is pressed.
    public delegate void PDownAction();
    public static event PDownAction OnPDown;

    private Stopwatch stopwatch = new Stopwatch();
    private void Start()
    {
        stopwatch.Start();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            stopwatch.Stop();
            float timeSinceClick = stopwatch.ElapsedMilliseconds;
            OnRightClick?.Invoke(timeSinceClick);
            stopwatch.Restart();
        }
        if (Input.GetMouseButtonDown(0)) {
            OnLeftClick?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnPDown?.Invoke();
        }
    }


}
