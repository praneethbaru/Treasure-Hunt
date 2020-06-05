using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualHandMovement : MonoBehaviour
{
    bool virtualTriggerButton;
    public GameObject rightHand;
    SimViveController simViveController;
    // Start is called before the first frame update
    void Start()
    {
         virtualTriggerButton = GameObject.Find("Real World Controller (right)").GetComponent<SimViveController>().triggerButton;
    }

    // Update is called once per frame
    void Update()
    {
        //move forward
        if(Input.GetKey(KeyCode.I))
        {
            Vector3 position = rightHand.transform.position;
            position.z += 0.02f;
            rightHand.transform.position = position;
        }

        //move backward
        if (Input.GetKey(KeyCode.K))
        {
            Vector3 position = rightHand.transform.position;
            position.z -= 0.02f;
            rightHand.transform.position = position;
        }

        //move left
        if(Input.GetKey(KeyCode.J))
        {
            Vector3 position = rightHand.transform.position;
            position.x -= 0.02f;
            rightHand.transform.position = position;
        }

        //move right
        if (Input.GetKey(KeyCode.L))
        {
            Vector3 position = rightHand.transform.position;
            position.x += 0.02f;
            rightHand.transform.position = position;
        }

        // Virtually pressing the trigger button
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("Real World Controller (right)").GetComponent<SimViveController>().triggerButton = true;
            //Debug.Log("Pressed primary button."+virtualTriggerButton);
        }

        if(Input.GetMouseButtonUp(0))
        {
            GameObject.Find("Real World Controller (right)").GetComponent<SimViveController>().triggerButton = false;
        }



    }
}
