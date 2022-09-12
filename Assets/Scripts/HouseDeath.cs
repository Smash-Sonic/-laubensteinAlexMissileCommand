using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bulletRed(Clone)") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
        }
    }
}
