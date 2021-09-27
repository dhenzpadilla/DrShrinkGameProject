using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name == "Player")
        {
            print("Teleport");
            //collisionGameObject.GetComponent<HealthScript>().AddShield();
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameObject Canvas = GameObject.Find("Canvas");
        Canvas.GetComponent<LoadLevel>().SceneLevel();
    }
}
