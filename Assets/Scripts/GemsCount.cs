using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GemsCount : MonoBehaviour
{
    private int gemsCount;
    public AudioSource gemCollected;
    public Renderer rend;
    public Text gemscountText;

    // Start is called before the first frame update
    void Start()
    {
        gemCollected = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (MasterScore.score == 10)
        //{
        //    Invoke("NextLevel", 3.0f);
        //}

        GameObject.Find("Text").GetComponent<Text>().text = "Gems:" + MasterScore.score + "/10";

        
    }



    //void NextLevel()
    //{

    //    SceneManager.LoadScene("Level2");
    //}


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gemCollected.Play();
            MasterScore.score++;

            rend = GetComponent<MeshRenderer>();
            rend.enabled = false;

            Destroy(gameObject, 0.5f);

            Debug.Log(MasterScore.score + " Gem(s) collected");
        }

    }
}

