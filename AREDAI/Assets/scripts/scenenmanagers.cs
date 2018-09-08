using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenenmanagers : MonoBehaviour {
    string ar;
    public GameObject screen;
    private videoplay vp;
    private string url;
	void Start () {
        vp = screen.GetComponent<videoplay>();
        ar = PlayerPrefs.GetString("AR","none");
        switch (ar)
        {
            case "eps":
                url = "file://" + Application.streamingAssetsPath + "/" + "eps.mp4";

                break;
            case "solar":
                url = "file://" + Application.streamingAssetsPath + "/" + "gh.mp4";

                break;
            case "animal":
                url = "file://" + Application.streamingAssetsPath + "/" + "ac.mp4";

                break;
            case "ab":
                url = "file://" + Application.streamingAssetsPath + "/" + "ab1.mp4";

                break;
            case "sew":
                url = "file://" + Application.streamingAssetsPath + "/" + "sw.mp4";

                break;
            case "none":
            default:
                url = "file://" + Application.streamingAssetsPath + "/" + "eps.mp4";
                break;
        }
        vp.videoplayfromurl(url);
    }
}
