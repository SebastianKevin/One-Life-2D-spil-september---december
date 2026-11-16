using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    private int currentHealth = 100;
    [SerializeField] private int maxHealth = 100;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    [SerializeField] private int damage = 10;

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
        Vector2 position = new Vector2(0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == transform.root) return; // Ignore collisions with self

        other.GetComponent<Health>()?.TakeDamage(10);
    }
}