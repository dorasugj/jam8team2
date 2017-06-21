using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour {


    public int pushPower=500;
    public int roteSpeed = 7;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Move()
    {

        transform.GetComponent<Rigidbody>().AddForce(transform.forward * pushPower);
    }
    
    public void Rote()
    {
        transform.Rotate(new Vector3(0, roteSpeed, 0));

    }

}
