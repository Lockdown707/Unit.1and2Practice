using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a Projectile From bulletspawn on player
            Instantiate(projectilePrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }
    }
}
