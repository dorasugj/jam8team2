using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartControl : MonoBehaviour {

    public AudioSource start;
    public bool start1;

    // Use this for initialization
    void Start () {
        start = GetComponent<AudioSource>();
        start1 = false;

    }

    // Update is called once per frame
    void Update () {
        if (start1 && !start.isPlaying)
        {
            //シーンの返還
            SceneManager.LoadScene("Play");
        }
    }

    public void StartButton()
    {
        if (!start1)
        {
            start.Play();
            start1 = true;
        }
    }
}
