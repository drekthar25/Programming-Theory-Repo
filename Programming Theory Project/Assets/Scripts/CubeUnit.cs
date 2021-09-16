using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnit : AtackUnits
{
    private bool grounded;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Shoot(1);
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump(690);
        }
    }
    public override void Shoot(int bulletNumber)
    {
        int i;
        for (i = 0; i < bulletNumber; i++)
        {
            base.Shoot(bulletNumber);
            Instantiate(bullet, transform.position + new Vector3(-1,0,0)+ offset, bullet.transform.rotation);
            Instantiate(bullet, transform.position + new Vector3(1, 0, 0) + offset, bullet.transform.rotation);
            
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
