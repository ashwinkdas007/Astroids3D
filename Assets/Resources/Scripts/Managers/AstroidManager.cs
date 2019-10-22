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
    GameObject astroidPrefab;
    Transform astroidParent;

    public List<Astroid> astroids { get; private set; }

    enum AstroidType {Asteroid_01_S, Asteroid_02_M, Asteroid_03_L, Asteroid_04_XL, Asteroid_05_XXL};


    public void Initialize()
    {
        astroidPrefab = Resources.Load<GameObject>("Others/AstroidPack");
        astroidParent = new GameObject("AstroidParent").transform;
        astroids = new List<Astroid>();
        //aliens.AddRange(GameObject.FindObjectsOfType<Alien>());
        //foreach (Alien a in aliens)
            //a.Initialize();
    }
}
