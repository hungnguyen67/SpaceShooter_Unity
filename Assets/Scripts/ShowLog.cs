using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // 1. Khai báo một biến để giữ thành phần SpriteRenderer
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // 2. Lấy thành phần SpriteRenderer từ đối tượng này khi game bắt đầu
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 3. Kiểm tra nếu tìm thấy component thì mới thực hiện đảo ngược trạng thái
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
