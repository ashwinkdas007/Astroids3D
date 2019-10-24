using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager
   
{
    
    #region Singleton
    public static PlayerManager Instance
    {
        get
        {
            return instance ?? (instance = new PlayerManager());
        }
    }
    private static PlayerManager instance;

    private PlayerManager() { }
    #endregion
    

    public Player player;
    public GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShip");

    public void Initialize()
    {
        player = GameObject.Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity).AddComponent<Player>();
        CreateMainCamera();
        player.Initialize();
    }

    public void PostInitialize()
    {
        player.PostInitialize();
    }
    public void Refresh()
    {
        player.Refresh();
    }

    public void PhysicsRefresh()
    {
        player.PhysicsRefresh();
    }

    void CreateMainCamera()
    {
        GameObject mainCamera = new GameObject("Main Camera");
        mainCamera.AddComponent<Camera>();
        mainCamera.AddComponent<AudioListener>();
        mainCamera.tag = "MainCamera";

        mainCamera.transform.parent = player.transform;
        mainCamera.transform.localPosition = new Vector3(-2.384186e-07f, 2.14f, -9.900001f);
        mainCamera.transform.Rotate(15.579f, 0, 0);

    }
}
