using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 15f; // Tốc độ bay của đạn

    void Update()
    {
        // Di chuyển đạn lên trên theo trục Y
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);

        // Xóa đạn khi bay quá xa (Y > 6 là ra khỏi màn hình điện thoại dọc)
        if (transform.position.y > 6f) 
        {
            Destroy(gameObject);
        }
    }
}