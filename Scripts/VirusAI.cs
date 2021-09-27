using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusAI : MonoBehaviour
{
    public float damage;

    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    
    Vector3 directionToTarget;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveVirus();
        
    }

    void MoveVirus()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(
                directionToTarget.x * moveSpeed,
                directionToTarget.y * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        GameObject player = GameObject.Find("Player");

        if (collisionGameObject.name == "Player")
        {

            if (player.GetComponent<HealthScript>().hp > 0)
            {
                collisionGameObject.GetComponent<HealthScript>().TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
