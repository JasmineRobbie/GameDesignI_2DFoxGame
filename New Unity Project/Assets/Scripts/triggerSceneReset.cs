using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSceneReset : MonoBehaviour
{
    //private void restartScene()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "spikes")
        {
            SceneManager.LoadScene("Morning");
        }
    }

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.transform.tag == "Platform")
    //    {
    //    }
    //}
}
