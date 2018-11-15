using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1_Handler : MonoBehaviour {

    public Button btnNext;
    private void Start()
    {
        btnNext.onClick.AddListener(BtnNextOnClick);
    }

    private void BtnNextOnClick()
    {
        SceneManager.LoadScene("Second");
    }
}
