using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use to acess LoadScene() method
using UnityEngine.SceneManagement;

// doesn't need to be in scene, so it doesnt need to inherit from MonoBehavior
public static class Utilities
{
    // creates variable to hold how many times our player has died/restarted the game
    public static int playerDeaths = 0;

    public static string UpdateDeathCount(ref int countReference)
    {
        countReference += 1;
        return "Next time you'll be at number " + countReference;
    }
    // holds our level restart logic
    public static void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;

        Debug.Log("Player deaths: " + playerDeaths);
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Player deaths: " + playerDeaths);
    }
    public static bool RestartLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 0.1f;

        return true;
    }
}

