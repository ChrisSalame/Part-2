using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void changePerspective()
    {
        //This code is what changes the scene when the scene button is pressed. The scene changes by cycling through the scene build settings and going from the first to the next
        //but it loops if it hits the last one
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int changeScene = (currentScene + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(changeScene);

    }
}
