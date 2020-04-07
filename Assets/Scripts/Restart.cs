using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void loadLevel() {
        SceneManager.LoadScene("PlankWalk");
    }
    public void quitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
