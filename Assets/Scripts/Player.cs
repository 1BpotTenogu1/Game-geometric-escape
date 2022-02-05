using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    public float jumpForce;
    
    private CharacterController _controller;
    private Vector3 _direction;
    public float MoveSpeed = 4;
    public float LeftRightSpeed = 5;
    bool alive = true;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
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
        if (transform.position.y < -1)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
         Jump();
         }
        
    }
    
    private void FixedUpdate()
    {
        if (!alive) return;
        _controller.Move(_direction * Time.fixedDeltaTime);
        
    }
    //попытка сделать прыжок 
    private void Jump()
    {
        _direction.y = jumpForce;
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(2);
        Debug.Log("Restart!");
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Lose")
        {
            Block.gameOver = true;
            SceneManager.LoadScene(2);
            Debug.Log("Restart!");
        }
    }


}
