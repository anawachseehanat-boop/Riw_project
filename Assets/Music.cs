using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance;

    void Awake()
    {
        // ถ้ามีเพลงอยู่แล้วให้ลบตัวใหม่
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        
        instance = this;

        // ทำให้เพลงไม่หายตอนเปลี่ยน Scene
        DontDestroyOnLoad(gameObject);
    }
}