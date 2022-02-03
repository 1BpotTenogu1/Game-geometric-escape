using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 4;
    public float LeftRightSpeed = 5;

    private float _jumpPower = 10f;
    private Rigidbody _rb;
    private readonly Vector3 _jumpDirection = Vector3.up;

    public bool isGrounded { get; private set; }

    private void Start()
    {
        this._rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World); 
        if (Input.GetKey(KeyCode.A)  || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBounddary.LeftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBounddary.RightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed * -1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
            this.Jump();
        
    }
    //попытка сделать прыжок 
    private void Jump()
    {
        if (this.isGrounded)
            this._rb.AddForce(this._jumpDirection * _jumpPower, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        var ground = other.gameObject.GetComponentInParent<Ground>();
        if (ground)
            this.isGrounded = true;
    }

    private void OnCollisionExit(Collision other)
    {
        var ground = other.gameObject.GetComponentInParent<Ground>();
        if (ground)
            this.isGrounded = false;
    }
}
