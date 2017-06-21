using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class message : MonoBehaviour {

    public Text flashText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        flashText.color = new Color
       (1, 1, 1, Mathf.PingPong(Time.time, 1));

    }
}
