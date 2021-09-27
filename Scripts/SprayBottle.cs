using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayBottle : MonoBehaviour
{
    private Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int direction()
        {
            if (transform.localScale.x < 0f)
            {
                return +1;
            }
            else
            {
                return -1;
            }
        }
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.up = new Vector3(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y,
            0f) * direction();
    }
}
