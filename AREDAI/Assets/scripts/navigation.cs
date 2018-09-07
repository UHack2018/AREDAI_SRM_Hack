using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigation : MonoBehaviour {
    string currentScene,nextscene;
	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene().name;
        switch (currentScene)
        {
            case "arloading":nextscene = "armode";
                break;
            case "splash":
                nextscene = "loading";
                break;
            case "vrloading":
                nextscene = "vrmode";
                break;
            default:
                nextscene = "menu";
                break;
     
        }
        StartCoroutine(changescene(nextscene));
    }
    IEnumerator changescene(string s)
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(s);
    }
}
