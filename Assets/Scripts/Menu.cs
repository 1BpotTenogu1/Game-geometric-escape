using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool isOpened = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void GoPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Menu!");
    }

}
