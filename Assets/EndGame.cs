using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject GameOverUI;

    // Update is called once per frame

    public void StartOver()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Level1");
    }

    public void QuitEnd()
    {
        Debug.Log("Quitting Game....");
    }
}