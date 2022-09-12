using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController gc = GameObject.FindObjectOfType<GameController>();
        if (collision.gameObject.name == "Explosion(Clone)") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "house") //slime health decrease and activates hitstop
        {
            Destroy(gameObject);
            gc.houseCount--;
        }
    }

}
