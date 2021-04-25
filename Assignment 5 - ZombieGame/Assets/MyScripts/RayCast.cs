using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    public float allowedDistance = 30.0f;
    public int demageAmount = 1;


    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hit,
                allowedDistance))
            {
                Debug.Log("Found " + hit.transform.tag + " at " + hit.distance);

                if ((hit.transform.tag == "Cube") ||
                    (hit.transform.tag == "Zombie"))
                {
                    hit.transform.SendMessage("damage", demageAmount);
                }
            }
        }
    }
}
