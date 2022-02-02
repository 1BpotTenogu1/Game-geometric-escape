using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 4;
    public float LeftRightSpeed = 5;
    
    
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
        
    }

    
}
