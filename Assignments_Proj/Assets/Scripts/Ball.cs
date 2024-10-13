using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    private float direction = 1;
    private void Awake() {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    // Coroutine Implementation
    public IEnumerator MoveWithSpeed(float speed) {
        var end = Time.time + 0.5f;
        float yLoc = transform.position.y;
        if (yLoc >= 9 || yLoc < -9)
            direction *= -1;
        while (Time.time < end) {
            rb.velocity = new Vector3(0, speed * direction, 0);
            yield return null;
        }
        rb.velocity = Vector3.zero;
        Debug.Log(gameObject.name + " is done moving (Coroutine)");
    }

    public async Task<string> MoveWithSpeedAsync(float speed) {
        var end = Time.time + 0.5f;
        float yLoc = transform.position.y;
        if (yLoc >= 9 || yLoc < -9)
            direction *= -1;
        while (Time.time < end) {
            rb.velocity = new Vector3(0, speed * direction, 0);
            await Task.Yield();
        }
        rb.velocity = Vector3.zero;
        return gameObject.name;
    }
}
