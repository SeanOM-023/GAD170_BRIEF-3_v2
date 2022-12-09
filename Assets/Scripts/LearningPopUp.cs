using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LearningPopUp : MonoBehaviour
{   
    public GameObject popUp;
    public TextMeshProUGUI popUpText; 
    public string popUpString;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
        popUpText.text = popUpString;
        popUp.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player"){
        popUp.SetActive(false);
        }
    }

    void IsTriggerExit(){
        popUp.SetActive(false);
    }
}
