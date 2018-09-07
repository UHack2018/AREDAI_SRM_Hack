using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoplayer : MonoBehaviour {
    private bool flag=false;
    public GameObject videoscreen;
    private VideoPlayer vp;
    private Renderer r;
    private Vector3 tp;
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("swipe on");
            tp = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 swipe = tp - Input.mousePosition;
            if (Mathf.Abs(swipe.x) >= 200.0f || Mathf.Abs(swipe.y) >= 300.0f)
            {
                PlayerPrefs.SetString("prev_scene", "armode");
                if (r.enabled==true)
                {
                    PlayerPrefs.SetString("AR", videoscreen.transform.name);
                }
                else
                {
                    PlayerPrefs.SetString("AR", "none");
                }
                SceneManager.LoadScene("vrloading");
            }
        }
    }
}
