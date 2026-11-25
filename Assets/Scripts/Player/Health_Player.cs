using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

public class Health_Player : MonoBehaviour
{
    public bool Player_Dead = false;
    private int currentHealth = 3;
    [SerializeField] private int maxHealth = 3;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    [SerializeField] private int damage = 1;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    private void Die()
    {
        Player_Dead = true;
        gameObject.SetActive(false);
    }
 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == transform.root) return; // Ignore collisions med sig selv

        other.GetComponent<Health_Player>()?.TakeDamage(damage);
    }
}