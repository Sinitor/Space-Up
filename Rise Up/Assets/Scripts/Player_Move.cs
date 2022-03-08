using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private bool _isDown;
    private Vector3 _delta;
    private Camera _cam;
    private Rigidbody2D _rb;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _cam = Camera.main;
    }

    private void Update()
    {
        if (transform.position.x >= 3 || transform.position.x <= -3 || transform.position.y <= -5 || transform.position.y >= 5.3)
        {
            transform.position = new Vector2(0, 0);
        }



        if (Input.GetMouseButtonDown(0) && _isDown == false)
        {
            _isDown = true;
            _delta = transform.position - MousePos();
        }
        if (_isDown)
        {
            _rb.MovePosition(_delta + MousePos());
        }
        if (Input.GetMouseButtonUp(0) && _isDown == true)
        {
            _isDown = false;
        }
    }

    private Vector3 MousePos()
    {
        return _cam.ScreenToWorldPoint(Input.mousePosition + Vector3.forward);
    }
}
