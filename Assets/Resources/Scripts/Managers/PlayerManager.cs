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
            if (instance == null)
            {
                instance = new PlayerManager();
            }
            return instance;
        }
    }
    private static PlayerManager instance;
    #endregion
    

    Player player;
    GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShip");

    public void Initialize()
    {
        player = GameObject.Instantiate(playerPrefab, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<Player>();
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
