﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
           
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null) //If you hit something take damage
            {
                //Debug.Log("Pew");
                target.TakeDamage(damage);
            }
        }
    }
}
