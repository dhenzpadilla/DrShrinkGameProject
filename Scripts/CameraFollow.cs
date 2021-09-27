using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed, yPos;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CameraTracker").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 targetPos = player.position;
            Vector2 smoothPos = Vector2.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);
            transform.position = new Vector3(
                Mathf.Clamp(smoothPos.x, -1.95f, 1.95f),
                Mathf.Clamp(smoothPos.y, -0.99f, 0.99f) + yPos, -15f);
        }
        else
        {
            return;
        }
    }
}
