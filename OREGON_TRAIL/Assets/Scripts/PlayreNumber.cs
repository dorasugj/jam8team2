using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayreNumber : MonoBehaviour {

    public int playreNumber;

    // Use this for initialization
    void Start () {
        playreNumber = 2;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetPlayerNumber()
    {
        return playreNumber;
    }
}
