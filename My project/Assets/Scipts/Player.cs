using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;
    private SpriteRenderer _sr;
    public float speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector2(-1, 0) * speed ;
            _animator.SetBool("Move", true);
            _sr.flipX = true;

        }
        else
        {
            _animator.SetBool("Move", false);
            _sr.flipX = false;
        }
    }
}
