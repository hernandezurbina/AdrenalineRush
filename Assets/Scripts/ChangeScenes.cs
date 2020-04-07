using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void loadDayScene() {
        SceneManager.LoadScene("MainScene");
    }
    public void loadNightScene() {
        SceneManager.LoadScene("NightScene");
    }
    public void quitGame() {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
