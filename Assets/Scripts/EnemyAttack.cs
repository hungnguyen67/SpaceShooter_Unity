using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth selfHealth; 
    public int collisionDamage = 1000;

    private void Start()
    {
        if (selfHealth == null) 
            selfHealth = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(collisionDamage);
            
            // Kẻ địch tự nổ sau khi đâm
            if (selfHealth != null) 
                selfHealth.TakeDamage(1000); 
        }
    }
}