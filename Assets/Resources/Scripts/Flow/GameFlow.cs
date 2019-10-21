using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow {

    #region singleton
    public static GameFlow Instance
    {
        get
        {
               return instance = instance ?? new GameFlow();
        }
    }
    private static GameFlow instance;
    #endregion

    public void Initialize()
    {
        PlayerManager.Instance.Initialize();
        //BulletManager.Instance.Initialize();
    }

    public void PostInitialize()
    {
        PlayerManager.Instance.PostInitialize();
        //BulletManager.Instance.PostInitialize();
    }
    public void Refresh()
    {
        PlayerManager.Instance.Refresh();
        //BulletManager.Instance.Refresh();
    }

    public void PhysicsRefresh()
    {
        PlayerManager.Instance.PhysicsRefresh();
        //BulletManager.Instance.PhysicsRefresh();
    }




}
