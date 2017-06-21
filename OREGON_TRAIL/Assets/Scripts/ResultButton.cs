using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultButton : MonoBehaviour {

    public AudioSource Tilte;
    public bool Tilte1;
        
    // Use this for initialization
    void Start () {
        Tilte = GetComponent<AudioSource>();
        Tilte1 = false;
    } 
	
	// Update is called once per frame
	void Update () {
		if(Tilte1 && !Tilte.isPlaying)
        {
            SceneManager.LoadScene("TitleScene");
        }
	}

    public void resultButton()
    {
        if (!Tilte1)
        {
            Tilte.Play();
            Tilte1 = true;
        }
    }
}
