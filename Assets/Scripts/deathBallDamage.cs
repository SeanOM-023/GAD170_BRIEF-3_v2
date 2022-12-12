using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBallDamage : MonoBehaviour
{
    public GameObject playerStats;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Player") 
        {
            Debug.Log("Bump");
            Debug.Log(collision.gameObject.name);
            playerStats.GetComponent<PlayerStats>().ReloadGame();
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