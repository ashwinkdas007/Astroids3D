using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienManager {

    #region Singleton
    public static AlienManager Instance
    {
        get
        {
            return instance ?? (instance = new AlienManager());
        }
    }

    private static AlienManager instance;

    private AlienManager() { }
    #endregion

    public List<Alien> aliens { get; private set; }
    GameObject alienPrefab;
    Transform alienParent;

    public void Initialize()
    {
        alienPrefab = Resources.Load<GameObject>("Prefabs/Alien");
        alienParent = new GameObject("AlienParent").transform;
        aliens = new List<Alien>();
        aliens.AddRange(GameObject.FindObjectsOfType<Alien>());
        foreach (Alien a in aliens)
            a.Initialize();
    }

    public void PhysicsRefresh()
    {
        foreach (Alien a in aliens)
            a.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        foreach (Alien a in aliens)
            a.PostInitialize();
    }

    public void Refresh()
    {
        foreach (Alien a in aliens)
            a.Refresh();
    }

    public Alien CreateAlien(Vector2 location)
    {
        Alien toRet = GameObject.Instantiate(alienPrefab, alienParent).GetComponent<Alien>();
        toRet.transform.position = location;
        toRet.Initialize();
        toRet.PostInitialize();
        aliens.Add(toRet);
        return toRet;
    }

    public void AlienDied(Alien e)
    {
        aliens.Remove(e);
    }
}
