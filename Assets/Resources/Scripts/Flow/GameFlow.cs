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
    private GameFlow() { }
    #endregion

    [HideInInspector]public bool startGame;

    public void Initialize()
    {
        if (startGame)
        {
            PlayerManager.Instance.Initialize();
            AstroidManager.Instance.Initialize();
        } 
        else
        {
            MainMenuManager.Instance.Initialize();
        }       
    }

    public void PostInitialize()
    {
        if (startGame)
        {
            PlayerManager.Instance.PostInitialize();
            //AstroidManager.Instance.PostInitialize();
        } 
        else
        {
            MainMenuManager.Instance.PostInitialize();
        }
    }
    public void Refresh()
    {
        if(startGame)
        {
            PlayerManager.Instance.Refresh();
            AstroidManager.Instance.Refresh();
        } 
        else
        {
            MainMenuManager.Instance.Refresh();
        } 
    }

    public void PhysicsRefresh()
    {
        if (startGame)
        {
            PlayerManager.Instance.PhysicsRefresh();
            //AstroidManager.Instance.PhysicsRefresh();
        }
        else
        {
            MainMenuManager.Instance.PhysicsRefresh();
        } 
    }




}
