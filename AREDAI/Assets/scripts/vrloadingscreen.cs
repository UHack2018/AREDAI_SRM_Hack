using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class vrloadingscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(VRenable());
        StartCoroutine(Vrmode());
    }

    IEnumerator VRenable()
    {
        XRSettings.LoadDeviceByName("cardboard");
        yield return new WaitForSeconds(5);
        XRSettings.enabled = true;
    }
    IEnumerator Vrmode()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("vrmode");
    }
}
