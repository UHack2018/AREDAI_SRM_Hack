using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour {
    private bool flag=false;
    public GameObject videoscreen;
    private VideoPlayer vp;
    private Renderer r;
	// Use this for initialization
	void Start () {
        vp = videoscreen.GetComponent<VideoPlayer>();
        vp.playOnAwake = false;
        r = videoscreen.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && r.enabled)
        {
            if (flag)
            {
                vp.Play();
                flag = !flag;
            }
            else
            {
                vp.Pause();
                flag = !flag;
            }
        }
        if (r.enabled==false)
        {
            vp.Stop();
        }
	}
}
