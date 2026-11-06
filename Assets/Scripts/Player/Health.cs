using UnityEngine;

public class Health : MonoBehaviour
{
    private int currentHealth = 100;
    [SerializeField] private int maxHealth = 100;

    private void Start()
    {
        currentHealth = maxHealth;
    }

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
        // Handle player death logic
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == transform.root) return; // Ignore collisions with self

        other.GetComponent<Health>()?.TakeDamage(10);
    }
}