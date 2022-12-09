using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBallDamage : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Player") 
        {
            Debug.Log("Bump");
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
        }

    // Start is called before the first frame update
    //void Start()
    //{
    //   // Debug.Log("I have life");
    //}
//
    //// Update is called once per frame
    //void Update()
    //{
    //    
    //}
//
    }
}