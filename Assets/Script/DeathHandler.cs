using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0; // Stops the game.
        Cursor.lockState = CursorLockMode.None; // Cursor.lockState: Determines whether the hardware pointer is locked to the center of the view, constrained to the window, or not constrained at all. CursorLockMode.None: Cursor behavior is unmodified.
        Cursor.visible = true; // Determines whether the hardware pointer is visible or not.
    }
}