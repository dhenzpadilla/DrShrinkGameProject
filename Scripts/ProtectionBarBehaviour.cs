using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProtectionBarBehaviour : MonoBehaviour
{
    private Image Protectionbar;
    public float CurrentHealth;
    public float MaxProtectionShield = 10;
    private float Player;

    // Start is called before the first frame update
    void Start()
    {
        //Find
        Protectionbar = GetComponent<Image>();
        GameObject PlayerHP = GameObject.Find("Player");

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        GameObject PlayerHP = GameObject.Find("Player");
        if (PlayerHP != null)
        {
            Player = PlayerHP.GetComponent<HealthScript>().hpShield;
            CurrentHealth = Player / MaxProtectionShield;
            Protectionbar.fillAmount = CurrentHealth;
        }
    }
}
