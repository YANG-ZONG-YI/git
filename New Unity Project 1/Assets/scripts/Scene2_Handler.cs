using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene2_Handler : MonoBehaviour {

    public Button btnreturn;

	// Use this for initialization
	void Start () {

        btnreturn.onClick.AddListener(BtnreturnOnClick);
	}

    private void BtnreturnOnClick()
    {
        SceneManager.LoadScene("Zero");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
