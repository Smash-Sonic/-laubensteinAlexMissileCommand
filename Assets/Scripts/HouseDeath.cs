using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDeath : MonoBehaviour
{
    public Transform houseLocal;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bulletRed(Clone)") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            StartCoroutine(exploHouse());
        }
    }
    IEnumerator exploHouse()
    {
        BulletBehavior bb = GameObject.FindObjectOfType<BulletBehavior>();
        GameObject explo2 = Instantiate(bb.explosion, houseLocal.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Destroy(explo2);
    }
}
