using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyhit : MonoBehaviour
{
    public GameObject projectilebehaviour;
    public Transform firepoint;
    public float projectilespeed = 20f;
    public float firerate = 0.5f;
    private float nextfiretime = 0f;

    private void Update()
    {
        if (gameObject.CompareTag("Player"))
        {
            if (Input.GetMouseButton(0)&& Time.time >= nextfiretime)
            {
                fireProjectile();
                nextfiretime = Time.time + firerate;
            }
        }
        else if (Time.time >= nextfiretime)
        {
            fireProjectile();
                nextfiretime = Time.time + firerate;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
       if(gameObject.tag== "Object" && other.tag =="Projectile")
        {
            Destroy(gameObject);
        } 
    }
    private void fireProjectile()
    {
        GameObject projectile = Instantiate(projectilebehaviour, firepoint.position,firepoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if(rb != null )
        {
            rb.AddForce(firepoint.forward * projectilespeed,ForceMode.VelocityChange);
        }
        Destroy(projectile, 3f);
    }
}
