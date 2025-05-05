using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveTrigger : MonoBehaviour
{
    public GameObject[] objects;
    public bool setActiveTo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(setActiveTo);
            }
            gameObject.SetActive(false);
        }
    }
}
