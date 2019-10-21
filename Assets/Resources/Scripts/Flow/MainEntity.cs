using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntity : MonoBehaviour
{
    void Start()
    {
        GameFlow.Instance.PostInitialize();
    }

    // Update is called once per frame
    void Update()
    {
        GameFlow.Instance.Refresh();
    }

    private void Awake()
    {
        GameFlow.Instance.Initialize();
    }

    private void FixedUpdate()
    {
        GameFlow.Instance.PhysicsRefresh();

    }
}
