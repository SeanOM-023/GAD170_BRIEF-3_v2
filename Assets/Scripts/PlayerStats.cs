using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    public HPbar hpBar;
    public GameObject popUp;
    public TextMeshProUGUI popUpText; 
    public string popUpString;
    float hpValue = 100f;
    float hpMax = 100f;

    

    public bool poisoned = false;

    // Start is called before the first frame update
    void Start()
    {
        hpBar.InitBar(hpMax);      
    }

    // Update is called once per frame
    void Update()
    {
        if (poisoned == true) {
            takeDamage(0.05f);
        }

    }

    public void takeDamage(float damage) {
        hpValue -= damage;
        hpBar.SetValue(hpValue);
    }

    void heal(float healing) {
        hpValue += healing;
        hpBar.SetValue(hpValue);
    }

        public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}