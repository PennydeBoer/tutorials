using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public float damageAmount = 25f;
    public GameObject player;
    [SerializeField] private string tagToCollideWith = "Projectile";
    public int hitCount = 0;
    public Text healthtext;

    private void Start()
    {
        UpdateHealthText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(tagToCollideWith))
        {
            health -= damageAmount;
            hitCount++;

            UpdateHealthText();
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            if (hitCount >= 4)
            {
                Destroy(gameObject);
            }
        }
    }
    
    private void UpdateHealthText()
    {
        healthtext.text = "Health: " + health.ToString();
    }
}
