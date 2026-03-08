using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public float speed = 5f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        transform.Translate(move * speed * Time.deltaTime, 0, 0);

        anim.SetFloat("Speed", Mathf.Abs(move));

        // ทำให้ตัวละครหันซ้ายขวา
    if (move != 0)
    {
        Vector3 scale = transform.localScale;
        scale.x = Mathf.Sign(move) * Mathf.Abs(scale.x);
        transform.localScale = scale;
    }

    }
}