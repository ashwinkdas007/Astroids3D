using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnable
{
    // Spawn a new game object at a specified position
    GameObject Spawn(GameObject prefab, Vector3 pos);


}