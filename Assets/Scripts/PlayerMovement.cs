﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField]
    private float _speed, _rightSpeed;
    private Vector3 _moveVector;
    private bool isDead;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _moveVector = Vector3.left * _rightSpeed;
        }
        else
        {
            _moveVector = Vector3.right * _rightSpeed;
        }
    }

    private void FixedUpdate()
    {
        if (isDead == false)
        {
            _rigidbody.MovePosition(transform.position + (Vector3.forward * _speed + _moveVector) * Time.fixedDeltaTime);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Lose();
        }
    }

    private void Lose()
    {
        isDead = true;
    }
}
