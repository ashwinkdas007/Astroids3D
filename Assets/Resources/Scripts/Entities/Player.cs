using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{


    public override void PhysicsRefresh()
    {
        base.PhysicsRefresh();

        Vector3 moveDir = new Vector3(0,0 , Input.GetAxis("Vertical"));
        Vector3 turnDir = new Vector3 (0, Input.GetAxis("Mouse X"), 0);
        
        Move(moveDir * moveForce);
        Rotate(turnDir * turnTorque);

    }

    public override void Refresh()
    {
        base.Refresh();

        Teleport();
    }


    void Teleport()
    {
        // check boundary, if touch, teleport to the other side
    }
}
