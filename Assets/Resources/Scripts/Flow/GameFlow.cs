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
        AstroidManager.Instance.Initialize();
    }

    public void PostInitialize()
    {
        PlayerManager.Instance.PostInitialize();
        //AstroidManager.Instance.PostInitialize();
    }
    public void Refresh()
    {
        PlayerManager.Instance.Refresh();
        AstroidManager.Instance.Refresh();
    }

    public void PhysicsRefresh()
    {
        PlayerManager.Instance.PhysicsRefresh();
        //AstroidManager.Instance.PhysicsRefresh();
    }




}
