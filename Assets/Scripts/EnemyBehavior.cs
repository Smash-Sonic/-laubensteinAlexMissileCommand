using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController gc = GameObject.FindObjectOfType<GameController>();
        if (collision.gameObject.name == "Explosion(Clone)") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "house1") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house2") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house3") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house4") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house5") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
        if (collision.gameObject.name == "house6") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }

    }
}
