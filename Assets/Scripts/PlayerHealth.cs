using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện bắt buộc để thực hiện chuyển cảnh

public class PlayerHealth : Health
{
    protected override void Die()
    {
        // 1. Gọi hàm Die của lớp cha (Health) để tạo vụ nổ và âm thanh
        base.Die(); 

        Debug.Log("GAME OVER: Đang chuyển từ SampleScene sang Scene Battle...");

        // 2. Lệnh chuyển sang Scene kết thúc có tên là "Battle"
        // Đảm bảo bạn đã lưu tên Scene là "Battle" (viết hoa chữ B)
        SceneManager.LoadScene("Battle"); 
    }
}