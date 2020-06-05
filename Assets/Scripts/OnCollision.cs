using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject gem;
    private int count=0;

    private void Start()
    {
        gem = GameObject.Find("gem_08");
    }

    public void OnTriggerEnter(Collider other)
    {
        count++;
        Debug.Log(""+count+" Gem(s) collected");
        gem.SetActive(false);
    }

    private void Update()
    {
        
    }

}

