using UnityEngine;

// Tên class đã được đổi để không bị trùng với các file cũ
public class SpaceShipShooting : MonoBehaviour
{
    [Header("Cấu hình đạn")]
    public GameObject bulletPrefab;    // Kéo Prefab viên đạn vào đây
    public float shootingInterval = 0.2f; // Tốc độ bắn (số càng nhỏ bắn càng nhanh)

    private float lastBulletTime; // Lưu thời gian lần bắn cuối

    void Update()
    {
        // Sử dụng GetMouseButton(0) để hỗ trợ bắn liên tục khi giữ chuột
        if (Input.GetMouseButton(0))
        {
            // Chỉ bắn nếu thời gian trôi qua lớn hơn khoảng chờ
            if (Time.time - lastBulletTime > shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;
            }
        }
    }

void Shoot()
{
    if (bulletPrefab != null)
    {
        // Tạo một vị trí mới cao hơn tâm tàu 0.5 đơn vị (mũi tàu)
        Vector3 firePoint = transform.position + new Vector3(0, 1f, 0); 
        
        // Tạo đạn tại vị trí mũi tàu thay vì tâm tàu
        Instantiate(bulletPrefab, firePoint, transform.rotation);
    }
    else
    {
        Debug.LogError("Bullet Prefab chưa được gán!");
    }
}
}