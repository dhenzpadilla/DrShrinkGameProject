using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    private Image Healthbar;
    public float CurrentHealth;
    private float MaxHealth;
    private float Player;

    // Start is called before the first frame update
    void Start()
    {
        //Find
        Healthbar = GetComponent<Image>();
        GameObject PlayerHP = GameObject.Find("Player");
        MaxHealth = PlayerHP.GetComponent<HealthScript>().hp;

    }
    
    // Update is called once per frame
    public void FixedUpdate()
    {
        GameObject PlayerHP = GameObject.Find("Player");
        if (PlayerHP != null)
        {
            Player = PlayerHP.GetComponent<HealthScript>().hp;
            CurrentHealth = Player / MaxHealth;
            Healthbar.fillAmount = CurrentHealth;
        }
    }
}
