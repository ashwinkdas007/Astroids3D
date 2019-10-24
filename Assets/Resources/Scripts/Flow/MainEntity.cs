using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntity : MonoBehaviour
{
    void Start()
    {
        if (!gameObject.name.Equals("SkyboxMove"))
            GameFlow.Instance.PostInitialize();
        if (gameObject.name.Equals("SkyboxMove"))
            SkyboxManager.Instance.PostInitialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameObject.name.Equals("SkyboxMove"))
            GameFlow.Instance.Refresh();
        if (gameObject.name.Equals("SkyboxMove"))
            SkyboxManager.Instance.Refresh();
    }

    private void Awake()
    {
        if (!gameObject.name.Equals("SkyboxMove"))
            GameFlow.Instance.Initialize();
        if (gameObject.name.Equals("SkyboxMove"))
            SkyboxManager.Instance.Initialize();
    }

    private void FixedUpdate()
    {
        if (gameObject.name.Equals("SkyboxMove"))
            SkyboxManager.Instance.PhysicsRefresh();
        if (!gameObject.name.Equals("SkyboxMove"))
            GameFlow.Instance.PhysicsRefresh();
    }
}
