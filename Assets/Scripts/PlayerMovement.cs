using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        // Cách đúng cho Orthographic camera (2D)
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;  // rất quan trọng – giữ Z = 0

        // Clamp để không ra khỏi màn hình
        mousePos.x = Mathf.Clamp(mousePos.x, -2.3f, 2.3f);
        mousePos.y = Mathf.Clamp(mousePos.y, -4.5f, 4.5f);

        // Di chuyển mượt
        transform.position = Vector3.Lerp(
            transform.position,
            mousePos,
            speed * Time.deltaTime
        );
    }
}