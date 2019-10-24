using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileManager
{
    #region Singleton
    public static MissileManager Instance
    {
        get
        {
            return instance ?? (instance = new MissileManager());
        }
    }

    private static MissileManager instance;

    private MissileManager() { }
    #endregion

    public List<Missile> missiles { get; private set; }
    public Transform missileSpawnPoint;
    GameObject missilePrefab;

    float missileFireCooldownTime = 3;
    float timer = 0;


    public void Initialize()
    {
        missilePrefab = Resources.Load<GameObject>("Others/StarSparrow/Prefabs/BonusContent/Missile");
        missileSpawnPoint = PlayerManager.Instance.player.transform.Find("MissileSpawnPoint");
        missiles = new List<Missile>();

    }

    public void Refresh()
    {

            timer -= Time.deltaTime;

        
    }

    public void PhysicsRefresh()
    {
        foreach(Missile m in missiles)
        {
            m.PhysicsRefresh();
        }
    }



    public void FireMissile()
    {
        if (timer <= 0)
        {
            timer = missileFireCooldownTime;

            GameObject go = GameObject.Instantiate(missilePrefab, missileSpawnPoint.position, missileSpawnPoint.rotation);
            go.AddComponent<Rigidbody>().useGravity = false;
            Missile m = go.AddComponent<Missile>();
            m.Initialize();
            //m.PostInitialize();
            missiles.Add(m);
        }
        
    }
}
