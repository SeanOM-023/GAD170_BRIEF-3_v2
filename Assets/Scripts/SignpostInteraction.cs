using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignpostInteraction : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
        collision.gameObject.GetComponent<playerInteractions>().OkToPush = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.name == "Player"){
        collision.gameObject.GetComponent<playerInteractions>().OkToPush = false;
        }
    }

    // Start is called before the first frame update
    //void Start()


    // Update is called once per frame
    //void Update()

}
