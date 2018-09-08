using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class playercontroller : MonoBehaviour {
    public GameObject textbook;
    public GameObject vrscreen;
    public GameObject c;
    private Renderer r;
    public GameObject chatbot;
    private ApiAiModule a;
    private bool play;
     private int i;
    public GameObject screen;
    private videoplay vp;
    // Use this for initialization
    void Start () {
        r = textbook.GetComponent<Renderer>();
        a = chatbot.GetComponent<ApiAiModule>();
        r.material.mainTexture = Resources.Load("1") as Texture2D;
        vp = screen.GetComponent<videoplay>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(c.transform.position, c.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "screen")
                {
                    vp.videoplayafterloading(play);
                    play = !play;
                }
                else if (hit.transform.name == "R")
                {
                    i++;
                    r.material.mainTexture = Resources.Load(((i % 16) + 1).ToString()) as Texture2D;
                }
                else if (hit.transform.name == "L")
                {
                    i--;
                    r.material.mainTexture = Resources.Load(((i % 16) + 1).ToString()) as Texture2D;
                    if (i <= 0)
                    {
                        i = 16;
                    }
                }
                else if (hit.transform.name == "chatbot")
                {
                    a.StartNativeRecognition();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(VRdisable());
            SceneManager.LoadScene("armode");
        }
    }
    IEnumerator VRdisable()
    {
        XRSettings.LoadDeviceByName("none");
        yield return new WaitForSeconds(1);
        XRSettings.enabled = true;
    }
}
