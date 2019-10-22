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

    public List<Astroid> astroid { get; private set; }
    GameObject[] astroidPrefabs;
    GameObject raycastSource;
    Transform astroidParent;

    int maxNumOfAstroids = 8;
    float astroidSpawnCooldownTime = 5;
    float timer = 0;

    public static int NumOfAstroids { get; set; }

    public List<Astroid> astroids { get; private set; }

    List<string> astroidType = new List<string> {"Asteroid_01_S", "Asteroid_02_M", "Asteroid_03_L", "Asteroid_04_XL", "Asteroid_05_XXL"};


    public void Initialize()
    {
        raycastSource = GameObject.FindGameObjectWithTag("RayCastSource");
        astroidPrefabs = new GameObject[5];
        for (int i = 0; i < 5; i++){
            astroidPrefabs[i] = Resources.Load<GameObject>("Others/AstroidPack/" + astroidType[i]);
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
                SpawnAstroid();
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

    void SpawnAstroid()
    {
        GameObject go = GameObject.Instantiate(astroidPrefabs[ProbabilityFunctions.DiceRoll(0,5)], GetRandomUnoccupiedLocation(), Quaternion.identity, astroidParent.transform);
        Astroid a = go.AddComponent<Astroid>();
        a.Initialize();
        astroids.Add(a);
    }
}
