using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultMenu : MonoBehaviour
{
    public void BackToMenu()
    {
        // Quay lại trang đầu tiên (MainMenu)
        SceneManager.LoadScene("MainMenu");
    }
}