using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{


    public void StartOver()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Start Over");
    }

    public void QuitEnd()
    {
        Debug.Log("Quitting Game....");
    }

}
