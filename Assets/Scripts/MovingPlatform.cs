using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] waypoints;
    private int waypointIndex;
    public float speed;

    private Transform nonScaleParent;
    
    // Start is called before the first frame update
    void Start()
    {
        nonScaleParent = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, speed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(distance <0.1f)
        {
            waypointIndex = (waypointIndex + 1) % waypoints.Length;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            collision.transform.parent = nonScaleParent;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.transform.parent = null;
        }
    }
}
