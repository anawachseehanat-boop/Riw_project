using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Prefab ของวัตถุที่ต้องการให้ตกลงมา
    public GameObject fallingPrefab;

    // ความถี่ในการ spawn (กี่วินาทีต่อครั้ง)
    public float spawnRate = 1f;

    // ระยะซ้ายขวาที่สุ่มตำแหน่งเกิด
    public float xRange = 7f;

    void Start()
    {
        // เรียกฟังก์ชัน SpawnObject ซ้ำ ๆ
        // เริ่มหลังจาก 1 วินาที และทำซ้ำทุก spawnRate วินาที
        InvokeRepeating("SpawnObject", 1f, spawnRate);
    }

    void SpawnObject()
    {
        // สุ่มตำแหน่งแกน X ระหว่าง -xRange ถึง xRange
        float randomX = Random.Range(-xRange, xRange);

        // กำหนดตำแหน่งเกิดของวัตถุ
        // X = ตำแหน่งสุ่ม
        // Y = ตำแหน่งของ Spawner
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        // สร้างวัตถุใหม่จาก Prefab ที่ตำแหน่งที่กำหนด
        Instantiate(fallingPrefab, spawnPosition, Quaternion.identity);
    }
}