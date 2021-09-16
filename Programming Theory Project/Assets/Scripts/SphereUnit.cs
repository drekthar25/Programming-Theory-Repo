using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereUnit : AtackUnits
{

    private bool grounded;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot(1);
        }
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump(300);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("player"))
        {
            grounded = true;
        }
    }
}
