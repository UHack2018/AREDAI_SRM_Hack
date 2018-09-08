using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {
    public GameObject textbook;
    public GameObject vrscreen;
    public GameObject c;
    private Renderer r;
    public GameObject chatbot;
    private ApiAiModule a;
    private bool play;
     private int i;
    // Use this for initialization
    void Start () {
        r = textbook.GetComponent<Renderer>();
        a = chatbot.GetComponent<ApiAiModule>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(c.transform.position, c.transform.forward, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "vrscreen")
                {
                    
                    play = !play;
                }
                else if (hit.transform.name == "R")
                {
                    i++;
                    r.material.mainTexture = Resources.Load(((i % 16) + 1).ToString()) as Texture3D;
                }
                else if (hit.transform.name == "L")
                {
                    i--;
                    r.material.mainTexture = Resources.Load(((i % 16) + 1).ToString()) as Texture3D;
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
    }
}
