using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour {

    public GameObject videoscreen;
    private VideoPlayer vp;
	// Use this for initialization
	void Start () {
        vp = videoscreen.GetComponent<VideoPlayer>();
        vp.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
