using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TingleWallButton : MonoBehaviour
{

    public GameObject popUp;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
            collision.gameObject.GetComponent<playerInteractions>().OkToTingle = true;
            Debug.Log("player is in tingle button zone");
            popUp.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
            collision.gameObject.GetComponent<playerInteractions>().OkToTingle = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
