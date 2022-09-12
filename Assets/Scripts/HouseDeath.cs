/*****************************************************************************
// File Name :         HouseDeath.cs
// Author :            Alex Laubenstein
// Creation Date :     September 11, 2022
//
// Brief Description : This is a script handles the destruction of houses.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bulletRed(Clone)") //if an enemy bullet collides kill house
        {
            Destroy(gameObject);
        }
    }
}
