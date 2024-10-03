using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class WandProjectile : MonoBehaviour, IPooledObject
{
    public float speed = 5f;
    public int lifespan = 3;

    private Rigidbody rb;

    public void OnObjectSpawn() {
        rb = GetComponent<Rigidbody>();
        rb.velocity = rb.transform.forward * speed;
    }
}
