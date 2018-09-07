using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu: MonoBehaviour {

	// Use this for initialization
	public void gotoarmode()
    {
        SceneManager.LoadScene("arloading");
    }
}
