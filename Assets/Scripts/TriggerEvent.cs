using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.gameObject.name} Enter Trigger");

        if(collision.tag == "Player")
        {
            Debug.Log("It's Player");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"{collision.gameObject.name} Exit Trigger");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log($"{collision.gameObject.name} Stay in Trigger");
    }
}
