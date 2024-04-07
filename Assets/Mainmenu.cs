using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame() 
    {   
        SceneManager.LoadScene("game");
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
