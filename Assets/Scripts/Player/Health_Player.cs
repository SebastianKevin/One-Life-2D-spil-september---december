using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

public class Health_Player : MonoBehaviour
{
    public bool Player_Dead = false;
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
        Player_Dead = true;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other == transform.root) return; // Ignore collisions with self

        other.GetComponent<Health_Player>()?.TakeDamage(damage);
    }
}