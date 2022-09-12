using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int houseCount = 6;
    public GameObject eBullet;
    public Vector3 cHouse;
    public bool house1Ded = false;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 1.5f); //spawn enemies
        cHouse = new Vector2(0.0f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (houseCount == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        // Restarts the game
        else if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
    void Spawn()
    {
        int random = Random.Range(1, 7);
        //sets spawn position
        Vector3 spawnPos = new Vector3();
        spawnPos.x = (Random.Range(-8.5f, 8.5f));
        spawnPos.y = 5.25f;
        
        while (houseCount > 0)
        {
            if (random == 1)
            {
                if (GameObject.Find("house1") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house1").transform.position;
                }
            }
            if (random == 2)
            {
                if (GameObject.Find("house2") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house2").transform.position;
                }
            }
            if (random == 3)
            {
                if (GameObject.Find("house3") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house3").transform.position;
                }
            }
            if (random == 4)
            {
                if (GameObject.Find("house4") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house4").transform.position;
                }
            }
            if (random == 5)
            {
                if (GameObject.Find("house5") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house5").transform.position;
                }
            }
            if (random == 6)
            {
                if (GameObject.Find("house6") == null)
                {
                    break;
                }
                else
                {
                    cHouse = GameObject.Find("house6").transform.position;
                }
            }
            GameObject eShot = Instantiate(eBullet, spawnPos, Quaternion.identity); // spawns in the enemy bullet
            StartCoroutine(eDirect(eShot, cHouse));
            break;
        }
    }

    IEnumerator eDirect(GameObject eshot, Vector3 tarHouse)
    {
        while (eshot.transform.position != tarHouse)
        {
            if (eshot == null)
            {
                break;
            }
            else
            {
                eshot.transform.position = Vector3.MoveTowards(eshot.transform.position, tarHouse, 25f * Time.deltaTime);
            }

            yield return new WaitForSeconds(0.01f);
        }
    }
}
