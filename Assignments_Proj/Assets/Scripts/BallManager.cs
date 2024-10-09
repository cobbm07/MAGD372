using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.ProBuilder.Shapes;

public class BallManager : MonoBehaviour
{
    [SerializeField] private Ball[] balls;
    private float speed = 5;
    public void MoveBalls() {
        for (var i = 0; i < balls.Length; i += 2) {
            StartCoroutine(balls[i].MoveWithSpeed(Mathf.Sqrt(i + 1) * speed));
        }
        for (var i = 1; i < balls.Length; i += 2) {
            balls[i].MoveWithSpeedAsync(Mathf.Sqrt(i + 1) * speed);
        }
    }
}
