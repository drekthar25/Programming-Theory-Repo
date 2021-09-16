using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleUnit : AtackUnits
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot(3);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(400);
        }
    }
}
