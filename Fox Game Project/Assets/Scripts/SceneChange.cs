using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void mainScene()
    {
        SceneManager.LoadScene("Morning");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "motherMorning")
        {
            SceneManager.LoadScene("Afternoon");
        }
        if (other.transform.tag == "motherAfternoon")
        {
            SceneManager.LoadScene("Evening");
        }
        if (other.transform.tag == "motherEvening")
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }
}