using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingbar : MonoBehaviour {
    public Transform LoadingBar;

    [SerializeField] private float currentAmount=0;
    [SerializeField] private float speed=4.0f;

    // Update is called once per frame
    void Update()
    {
        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount);
        }
        else
        {
            SceneManager.LoadScene("menu");
                }

        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }

}
