using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDamage : MonoBehaviour
{

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "Player") {
            Debug.Log("Bump");
            Debug.Log(collision.gameObject.name);
            collision.gameObject.GetComponent<PlayerStats>().takeDamage(10f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
