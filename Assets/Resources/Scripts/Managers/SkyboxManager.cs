using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager
{

    #region Singleton
    public static SkyboxManager Instance
    {
        get
        {
            return instance ?? (instance = new SkyboxManager());
        }
    }
    private static SkyboxManager instance;
    #endregion

    TitleShipMovement titleShipMovement;
    
    public void Initialize()
    {
        GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/SpaceShipTitle");
        titleShipMovement = GameObject.Instantiate(playerPrefab, new Vector3(0, 0, 16),new Quaternion(0,90,0,90)).GetComponent<TitleShipMovement>();
        titleShipMovement.Initialize();

    }

    public void PostInitialize()
    {
        titleShipMovement.PostInitialize();
    }
    public void Refresh()
    {
        titleShipMovement.Refresh();
    }

    public void PhysicsRefresh()
    {
        //RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2);
        titleShipMovement.PhysicsRefresh();
    }
}
