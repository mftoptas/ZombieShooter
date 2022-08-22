using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene(0); // Load the first scene.
        Time.timeScale = 1; // Starts the game.
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the game.
    }
}