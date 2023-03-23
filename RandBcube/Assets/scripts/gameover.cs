using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void start()
    {
        SceneManager.LoadScene(0);
    }
   
    
}