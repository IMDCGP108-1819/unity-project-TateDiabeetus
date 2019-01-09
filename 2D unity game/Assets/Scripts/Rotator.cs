using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Transform player;
    //slowed rotation so it isnt instant
    float rotSpeed = 180f;

    // Update is called once per frame
    void Update()
    {
        //finds Player again if destroyed at any point
        if(player == null)
        {
            GameObject go = GameObject.Find("Player");
                if(go != null)
            {
                player = go.transform;
            }
        }
        //checks again for player. retrys again if not found
        if (player == null)
            return;
        //player found, code for object to rotate towards it
        Vector3 dir = player.position - transform.position;
        dir.Normalize();
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle );
       transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}
