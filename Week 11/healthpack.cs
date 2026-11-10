using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healAmount = 10;
    public int maxHealth = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Already at full health? Do nothing.
            if (playerHealth.health >= maxHealth)
            {
                return;
            }

            // Heal, but never go above maxHealth
            playerHealth.health += healAmount;
            if (playerHealth.health > maxHealth)
            {
                playerHealth.health = maxHealth;
            }

            // Health pack destroys itself
            Destroy(gameObject);
        }
    }
}
