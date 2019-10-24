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
    

    Player player;
    public GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShip");

    public void Initialize()
    {
        player = GameObject.Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity).AddComponent<Player>();
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
}
