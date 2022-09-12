/*****************************************************************************
// File Name :         EnemyBehavior.cs
// Author :            Alex Laubenstein
// Creation Date :     September 11, 2022
//
// Brief Description : This is a script handles the destruction of enemy bullets and
                       decrements house count.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController gc = GameObject.FindObjectOfType<GameController>();
        if (collision.gameObject.name == "Explosion(Clone)") //if hit by explosion destroy bullet
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "house1") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house2") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house3") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house4") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house5") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house6") //if hit by house destroy bullet and decrement count
        {
            Destroy(gameObject);
            gc.houseCount--;
        }

    }
}
