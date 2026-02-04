using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die(); // Chạy lệnh nổ và hủy của lớp cha
        Debug.Log("GAME OVER: Người chơi đã chết!");
    }
}