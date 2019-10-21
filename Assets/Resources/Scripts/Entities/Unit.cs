using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected Rigidbody rb;
    public float moveForce = 30;
    public float turnTorque = 15;

    public virtual void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void PostInitialize()
    {

    }

    public virtual void Refresh()
    {

    }

    public virtual void PhysicsRefresh()
    {

    }

    public virtual void Move(Vector3 force)
    {
        rb.AddRelativeForce(force);
    }

    public virtual void Rotate(Vector3 torque)
    {
        rb.AddRelativeTorque(torque);
    }
}
