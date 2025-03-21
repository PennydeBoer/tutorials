using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private ParticleSystem ps;
    private Renderer r;
    private AudioSource source;
    private KeepScore scoreScript;
    void Start()
    {
        scoreScript = FindObjectOfType<KeepScore>();
        ps = GetComponent<ParticleSystem>();
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps.Stop();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            scoreScript.AddScore(1);
            ps.Play();
            source.Play();  
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
        }
    }
}
