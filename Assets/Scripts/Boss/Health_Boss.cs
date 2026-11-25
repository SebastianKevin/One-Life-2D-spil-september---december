using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

public class Health_Boss : MonoBehaviour
{
    public bool Boss_Dead = false;
    private int currentHealth = 100;
    [SerializeField] private int maxHealth = 100;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    [SerializeField] private int damage = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spear"))
        {
            TakeDamage(damage);
        }
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
        Boss_Dead = true;
        gameObject.SetActive(false);
    }
}