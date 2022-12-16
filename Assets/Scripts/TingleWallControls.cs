using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TingleWallControls : MonoBehaviour
{
    // Start is called before the first frame update
void Start()
    {
        EventBus.Current.DestroyTingleWall += Vanish;
    }

    void Vanish()
    {
        // plays audio and turn off and on MeshRenderer and BoxCollider
        gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
        gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;

    }

    void OnDestroy() 
    {

        EventBus.Current.DestroyTingleWall -= Vanish;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
