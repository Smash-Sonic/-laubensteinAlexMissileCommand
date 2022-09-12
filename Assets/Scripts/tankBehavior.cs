/*****************************************************************************
// File Name :         TankBehavior.cs
// Author :            Alex Laubenstein
// Creation Date :     September 11, 2022
//
// Brief Description : This is a script handles barrel rotation.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehavior : MonoBehaviour
{
    // Update is called once per frame   
    void Update()//moves the barrel to mouse position
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + 270);
    }
}
