using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    /// <summary>
    /// Loads the next scene in the queue
    /// scene queue can be found in File --> Build Settings
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene("Akmal - Scene");
    }

    /// <summary>
    /// testing for back button / redo button
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Loads the next scene in the queue
    /// scene queue can be found in File --> Build Settings
    /// </summary>
    public void NextScene()
    {
        SceneManager.LoadScene("Hamish - Scene");
    }
}
