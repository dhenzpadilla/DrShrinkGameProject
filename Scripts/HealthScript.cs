using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public float startHealth, hp;
    public float startHealthShield = 0f, hpShield;
    private float shield = 10;

    //public HealthBarBehaviour HealthBar;
    //public ProtectionBarBehaviour ProtectionBar;


    /*public static bool gameOver;
    public GameObject GameOverScreen;*/
    // Start is called before the first frame update
    void Start()
    {
        hp = startHealth;
        hpShield = startHealthShield;
        //GameObject PlayerShield = GameObject.Find("Player");
        //shield = PlayerShield.GetComponent<ProtectionBarBehaviour>().MaxProtectionShield;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator VirusDamage(float damage)
    {
        if (isTouchByVirus)
        {
            hp -= damage;
            Debug.Log(hp);
            isTouchByVirus = false;
            yield return new WaitForSeconds(0.1f);
            isTouchByVirus = true;
        }
    }*/

    public void TakeDamage(float damage)
    {
        if (hpShield > 0f)
            hpShield -= damage;
        else if (hpShield == 0f)
        {
            hp -= damage;
            if (hp <= 0f)
            {
                Die();
            }
        }
    }

    public void AddShield()
    {
        if (hpShield != shield)
        {
            hpShield += 1f;
        }
        else
            return;
    }

    void Die()
    {
        if (gameObject.name == "Virus(Clone)")
            ScoreManager.scoreValue += 1;
        
        Destroy(gameObject);
    }
}
