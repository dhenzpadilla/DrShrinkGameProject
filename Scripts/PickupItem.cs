using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public float dieTime;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Timer());   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "Player")
        {
            print("Item picked up!");
            collisionGameObject.GetComponent<HealthScript>().AddShield();
            Die();
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }
    void Die()
    {
        Destroy(gameObject);
    }

}
