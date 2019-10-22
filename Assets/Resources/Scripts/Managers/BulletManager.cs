using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager
{
    #region Singleton
    public static BulletManager Instance
    {
        get
        {
            return instance ?? (instance = new BulletManager());
        }
    }

    private static BulletManager instance;

    private BulletManager() { }
    #endregion
}
