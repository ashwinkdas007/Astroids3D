using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidManager
{
    #region Singleton
    public static AstroidManager Instance
    {
        get
        {
            return instance ?? (instance = new AstroidManager());
        }
    }

    private static AstroidManager instance;

    private AstroidManager() { }
    #endregion

    GameObject[] astroidPrefabs;
    GameObject raycastSource;
    Transform astroidParent;

    int maxNumOfAstroids = 8;
    float astroidSpawnCooldownTime = 5;
    float timer = 0;

    public static int NumOfAstroids { get; set; }

    public List<Astroid> astroids { get; private set; }

    List<string> astroidType = new List<string> {"Asteroid 1", "Asteroid 2", "Asteroid 3"};


    public void Initialize()
    {
        raycastSource = GameObject.FindGameObjectWithTag("RayCastSource");
        astroidPrefabs = new GameObject[astroidType.Count];
        for (int i = 0; i < astroidType.Count; i++){
            astroidPrefabs[i] = Resources.Load<GameObject>("Others/Asteroids Pack/Assets/Prefabs/" + astroidType[i]);
        }
        astroidParent = new GameObject("AstroidParent").transform;
        astroids = new List<Astroid>();

    }

    public void Refresh()
    {
        if (NumOfAstroids <= maxNumOfAstroids)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = astroidSpawnCooldownTime;
                SpawnRandomAstroid();
                NumOfAstroids++;
            }
        }
    }

    Vector3 GetRandomUnoccupiedLocation()
    {
        Vector3 pos;
       // do
        //{
            pos = new Vector3(
            UnityEngine.Random.Range(-20, 20),
            0,
            UnityEngine.Random.Range(-20, 20));
       // }
        //while (Physics.Raycast(raycastSource.transform.position, pos - raycastSource.transform.position, Mathf.Infinity, LayerMask.NameToLayer("Cube")));

        //Physics.CheckSphere

        return pos;
    }

    void SpawnRandomAstroid()
    {
        GameObject go = GameObject.Instantiate(astroidPrefabs[ProbabilityFunctions.DiceRoll(astroidType.Count)], GetRandomUnoccupiedLocation(), Quaternion.identity, astroidParent.transform);
        Astroid a = go.AddComponent<Astroid>();
        a.Initialize();
        a.PostInitialize();
        astroids.Add(a);
    }
}
