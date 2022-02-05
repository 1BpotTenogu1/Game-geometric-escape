using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
        
     void Start()
     {
        gameOver = false; 
     }
   


    void Update()
    {
        if (gameOver)
        {
            
            gameOverPanel.SetActive(true);
        }
    }
}
