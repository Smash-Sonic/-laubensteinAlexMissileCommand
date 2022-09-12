using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int houseCount = 6;

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
}
