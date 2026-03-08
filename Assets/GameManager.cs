using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ตัวแปร static เอาไว้ให้ Script อื่นเรียกใช้ GameManager ได้
    public static GameManager instance;

    // ตัวแปร Text UI สำหรับแสดงคะแนน
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    // UI ที่จะแสดงตอน Game Over
    public GameObject gameOverText;
    public GameObject homeButton;
    public GameObject restartButton;

    // ตัวแปรเก็บคะแนน
    int score = 0;

    // ตัวแปรเก็บคะแนนสูงสุด
    int highScore = 0;

    void Awake()
    {
        instance = this; // กำหนด instance ให้ Script อื่นเรียกใช้ได้

        Time.timeScale = 1f; // ทำให้เกมทำงานปกติ (ไม่หยุด)
    }

    void Start()
    {
        // ซ่อน UI ตอนเริ่มเกม
        gameOverText.SetActive(false);
        homeButton.SetActive(false);
        restartButton.SetActive(false);

        // โหลด High Score จาก PlayerPrefs (ถ้าไม่มีจะเป็น 0)
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        // แสดง High Score บนหน้าจอ
        highScoreText.text = "High Score : " + highScore;
    }

    public void AddScore()
    {
        // เพิ่มคะแนน
        score++;

        // อัพเดตคะแนนบน UI
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        // หยุดเกม
        Time.timeScale = 0f;

        // ถ้าคะแนนปัจจุบันมากกว่า High Score
        if(score > highScore)
        {
            highScore = score; // อัพเดต High Score

            // บันทึก High Score ลงเครื่อง
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        // แสดง UI Game Over
        gameOverText.SetActive(true);
        homeButton.SetActive(true);
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        // ทำให้เกมกลับมาทำงานปกติ
        Time.timeScale = 1f;

        // โหลดฉากเดิมใหม่ (รีสตาร์ทเกม)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}