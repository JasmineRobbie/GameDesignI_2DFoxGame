using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerSceneReset : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "spikes")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.transform.tag == "checkPoint")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
