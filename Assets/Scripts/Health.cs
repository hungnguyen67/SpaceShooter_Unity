using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Settings")]
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 100;
    
    protected int healthPoint;

    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        Debug.Log($"{gameObject.name} nhận {damage} sát thương. Còn lại: {healthPoint}");

        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Hủy hiệu ứng nổ sau 1 giây
        }
        Destroy(gameObject);
    }
}