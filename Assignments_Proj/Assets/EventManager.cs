using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction(float timeSinceClick);
    public static event ClickAction OnLeftClick;

    public delegate void PDownAction();
    public static event PDownAction OnPDown;

    private Stopwatch stopwatch = new Stopwatch();
    private void Start()
    {
        stopwatch.Start();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            stopwatch.Stop();
            float timeSinceClick = stopwatch.ElapsedMilliseconds;
            OnLeftClick?.Invoke(timeSinceClick);
            stopwatch.Restart();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnPDown?.Invoke();
        }
    }


}
