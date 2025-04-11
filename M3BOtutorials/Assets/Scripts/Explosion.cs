using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject particle;
    private GameObject explosion;
    [SerializeField] private string tag;
    
    private void OnTriggerEnter(Collider other)
    {
        explosion = Instantiate(particle, transform.position, transform.rotation);
        Destroy(explosion, 2f);  
        if (other.tag == tag)
        {
            Destroy(gameObject);
        }
    }
    
        
  
}
