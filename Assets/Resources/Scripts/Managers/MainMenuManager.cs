using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager
{

    #region Singleton
    public static MainMenuManager Instance
    {
        get
        {
            return instance ?? (instance = new MainMenuManager());
        }
    }
    private static MainMenuManager instance;

    private MainMenuManager() { }
    #endregion

    MainMenuShip mainMenuShip;
    
    public void Initialize()
    {
        GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShipTitle");
        mainMenuShip = GameObject.Instantiate(playerPrefab, new Vector3(0, 0, 16),new Quaternion(0,90,0,90)).AddComponent<MainMenuShip>();
        mainMenuShip.Initialize();

    }

    public void PostInitialize()
    {
        mainMenuShip.PostInitialize();
    }
    public void Refresh()
    {
        mainMenuShip.Refresh();
    }

    public void PhysicsRefresh()
    {
        //RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2);
        mainMenuShip.PhysicsRefresh();
    }
}
