using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        GameFlow.Instance.startGame = true;
        GameFlow.Instance.Initialize();
        SceneManager.LoadScene("MainScene");
    }

    /*public void GotoMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }*/
 
}
