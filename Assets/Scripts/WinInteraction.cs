using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinInteraction : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<playerInteractions>().OkToWin = true;
            Debug.Log("player is in win zone");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<playerInteractions>().OkToWin = false;
        }
    }

}
