using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    bool counted = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !counted) // ถ้าวัตถุชนกับ Ground และยังไม่ได้นับคะแนน
        {
            counted = true;
            GameManager.instance.AddScore();
            Destroy(gameObject); // ลบวัตถุที่ตกออกจากเกม
        }

        if (collision.gameObject.CompareTag("Player")) // ถ้าวัตถุชนกับ Player
        {
            GameManager.instance.GameOver();
        }
    }
}