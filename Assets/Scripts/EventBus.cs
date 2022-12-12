using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    //Makes an Event 
    public static EventBus Current { get { return _current; } }


    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}