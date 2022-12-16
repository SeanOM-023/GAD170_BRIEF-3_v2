using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteractions : MonoBehaviour
{


    public bool OkToPush = false;
    public bool OkToTingle = false;
    public bool OkToWin = false;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if (OkToPush == true && Input.GetKeyDown("e"))
        {
            gameObject.GetComponent<PlayerStats>().ReloadGame();
        }

        if (OkToTingle == true && Input.GetKeyDown("e"))
        {
            Debug.Log("Player is OK to tingle and has pressed E");  
            EventBus.Current.DestroyTingleWallTrigger();
        }

        if (OkToWin == true && Input.GetKeyDown("e"))
        {
            gameObject.GetComponent<PlayerStats>().ReloadGame();
            EventBus.Current.WinState();
        }
        
            
    }
        
}
