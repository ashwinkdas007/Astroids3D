using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager
{
    #region Singleton
    public static LevelManager Instance
    {
        get
        {
            return instance ?? (instance = new LevelManager());
        }
    }

    private static LevelManager instance;

    private LevelManager() { }
    #endregion

    int currentLevel;
    int astroidCount;
}
