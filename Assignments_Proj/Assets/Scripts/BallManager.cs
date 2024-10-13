using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.ProBuilder.Shapes;

public class BallManager : MonoBehaviour
{
    [SerializeField] private Ball[] balls;
    private float speed = 5;
    public async void MoveBalls() {

        // Move all "Even Index" balls via Coroutine
        for (var i = 0; i < balls.Length; i += 2) {
            StartCoroutine(balls[i].MoveWithSpeed(speed));
        }

        // Move all "Odd Index" balls via Async
        for (var i = 1; i < balls.Length; i += 2) {
            string ballName = await balls[i].MoveWithSpeedAsync(speed);
            Debug.Log(ballName + " is done moving (Async)");
        }
    }
}
