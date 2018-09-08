using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class videoplay : MonoBehaviour {
    private VideoPlayer cp;
	void Start () {
        cp = gameObject.GetComponent<VideoPlayer>();
	}
	
    public void videoplayfromurl(string a)
    {
        cp.url = a;
        StartCoroutine(prepvideo());
    }
    public void videoplayafterloading( bool play)
    {
        if (play)
        {
            cp.Play();
        }
        else
        {
            cp.Pause();
        }
    }
    IEnumerator prepvideo()
    {
        cp.Prepare();
        yield return new WaitForSeconds(1);
    }
}
