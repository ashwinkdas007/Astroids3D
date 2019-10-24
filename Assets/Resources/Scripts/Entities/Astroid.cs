using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    public float tumble = 0.25f;

    public void Initialize()
    {
        
    }

    public void PostInitialize()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    public void Refresh()
    {

    }

    public void PhysicsRefresh()
    {

    }
}
