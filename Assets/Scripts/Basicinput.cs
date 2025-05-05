using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicinput : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Button Fire1 Down");
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log($"H : {h} - V : {v}");
    }
}
