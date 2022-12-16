using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHasWon : MonoBehaviour
{
    public GameObject popUp;
    public TextMeshProUGUI popUpText; 
    public string popUpString;

    // Start is called before the first frame update
    void Start()
    {
        if (EventBus.Current.gameWon == true)
        {
        popUpText.text = popUpString;
        popUp.SetActive(true);
        }   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
