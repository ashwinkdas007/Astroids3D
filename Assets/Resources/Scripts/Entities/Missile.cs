using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float force = 10;

    Rigidbody rb;

    public void Initialize()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        //rb.AddForce(transform.forward * force);
    }

    public void PostInitialize()
    {
        
    }

    public void PhysicsRefresh()
    {
        rb.AddForce(MissileManager.Instance.missileSpawnPoint.forward * force);
    }
}
