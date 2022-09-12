/*****************************************************************************
// File Name :         BulletBehavior.cs
// Author :            Alex Laubenstein
// Creation Date :     September 11, 2022
//
// Brief Description : This is a script handles the bullet's actions and properties.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //declare variables
    public Transform spawnPoint;
    public GameObject bullet;
    public GameObject explosion;
    public float bulletSpeed = 20f;
    public Vector3 target;
    private Vector3 scaleExplosion;
    private Vector3 point;
    private Camera cam;
    private bool atPos = false;

    void Start()
    {
        target = new Vector2(0.0f, 0.0f); //makes target a zeroed vector 2
        scaleExplosion = new Vector3(1f, 1f, 1f); //sets the scale for the explosion
        cam = Camera.main; //cam = cam
    }
    // Update is called once per frame
    void Update()
    {
        point = cam.ScreenToWorldPoint(Input.mousePosition); //sets the point variable to the mouse
        point.z = 0;
        if (Input.GetButtonDown("Fire1")) //if fire button is pressed set the target to where the mouse was clicked and spawn the bullet
        {
            atPos = false;
            target = point;
            GameObject shot = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            StartCoroutine(Fire(shot, target));
        }
    }

    IEnumerator Fire(GameObject shot, Vector3 curTarget) //guides bullet to it's destination and manages explosion
    {
        
        while (shot.transform.position != curTarget)
        {
            shot.transform.position = Vector3.MoveTowards(shot.transform.position, curTarget, 50f * Time.deltaTime);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(.01f);
        Destroy(shot);
        GameObject explo = Instantiate(explosion, target, Quaternion.identity); //spawn explosion
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale += scaleExplosion;//increase
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale += scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale += scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale += scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale -= scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale -= scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale -= scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale -= scaleExplosion;
        yield return new WaitForSeconds(.1f);
        explo.transform.localScale -= scaleExplosion;//decrease
        Destroy(explo);//cease
        
        atPos = true;
    }
}
