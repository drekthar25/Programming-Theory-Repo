using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackUnits : MonoBehaviour 
{
  
    public GameObject bullet;
    public Vector3 offset { get; private set; }

    // Start is called before the first frame update
    public virtual void Shoot(int bulletNumber)
    {
        int i;
        for(i=0; i < bulletNumber; i++)
        {
            offset = new Vector3(0, 0, 1);
            Instantiate(bullet, transform.position + offset, bullet.transform.rotation);
        }
    }
    public void Jump(int jumpHeight)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * Time.deltaTime * jumpHeight , ForceMode.Impulse);
    }
}
