using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private Transform sprayPos;
    
    [SerializeField]
    private GameObject sprayProjectile;

    public int projectileSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SprayFire();
        }
    }

    private void SprayFire()
    {
        int direction()
        {
            if (transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }
        //Summon Projectile
        GameObject newSpray = Instantiate(sprayProjectile, sprayPos.position, sprayPos.rotation);

        //Sprite Direction
        newSpray.GetComponent<Rigidbody2D>().velocity = sprayPos.right * direction() * projectileSpeed;

        //Sprite Transform
        newSpray.transform.localScale = new Vector2(newSpray.transform.localScale.x * direction(), newSpray.transform.localScale.y);
    }
    /*public float attackSpeed, attackTimer;
    private bool isAttacking;

    public Transform attackPos;
    public GameObject spray;
    
    // Start is called before the first frame update
    void Start()
    {
        isAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isAttacking)
        {
            StartCoroutine(Attack());
        }
    }
    IEnumerator Attack()
    {
        int direction()
        {
            
            if (transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }

        isAttacking = true;
        GameObject newSpray = Instantiate(spray, attackPos.position, Quaternion.identity);
        //newSpray.AddRelativeForce(new Vector2(0f + randomDirectionModifier, 1f) * randomSpeed);
        newSpray.GetComponent<Rigidbody2D>().velocity = new Vector2(attackSpeed * direction() * Time.fixedDeltaTime, 0f);
        newSpray.transform.localScale = new Vector2(newSpray.transform.localScale.x * direction(), newSpray.transform.localScale.y);

        yield return new WaitForSeconds(attackTimer);
        isAttacking = false;
    }*/
}
