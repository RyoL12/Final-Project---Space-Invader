using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Projectile : MonoBehaviour
{
    public GameObject PrefabProjectile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(PrefabProjectile, transform.position, Quaternion.identity);
        }
    }
}
