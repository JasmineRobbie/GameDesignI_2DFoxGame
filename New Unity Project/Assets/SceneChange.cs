using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void mainScene()
    {
        SceneManager.LoadScene("mainScene");
    }
    //public void Scene2()
    //{
    //    SceneManager.LoadScene("Scene2");
    //}
    public void quitGame()
    {
        Application.Quit();
    }
}