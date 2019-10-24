using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuShip:MonoBehaviour
{
    //public GameObject go;
    bool Up = true;


    float angle = 360.0f; // Degree per time unit
    float time = 1.0f; // Time unit in sec
    Vector3 axis = Vector3.right; // Rotation axis, here it the yaw axis

    public void Initialize()
    {
        
    }

    public void PostInitialize()
    {
        
    }
    public void Refresh()
    {

        
    }

    public void PhysicsRefresh()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2);
        goUp();
        //Debug.Log(transform.position.y);
        //barrelRoll();
    }

    void goUp()
    {
        if (transform.position.y >= 5 || !Up)
        {
            Up = false;
            goDown();
        }
        else if(Up)
        {
            transform.position += new Vector3(0, Time.deltaTime, 0);
        }
    }

    void goDown()
    {
        if (transform.position.y <= -5)
        {
            Up = true;
            goUp();
        }
        else if(!Up)
        {
            transform.position -= new Vector3(0, Time.deltaTime, 0);
        }
    }

    void barrelRoll()
    {
        GetComponent<Transform>().RotateAround(transform.position, axis, angle * Time.deltaTime / time);
    }
}
