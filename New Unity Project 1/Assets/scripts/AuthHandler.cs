using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AuthHandler : MonoBehaviour
{
    public Text TextKey;
    public Text InputKey;
    public Button BtnGo;

    // Use this for initialization
    private void Start()
    {
        BtnGo.onClick.AddListener(OnBtnGoClick);
    }

    private void OnBtnGoClick()
    {
        Debug.Log("OnBtnGoClick");
        Debug.Log("Input Text=" + InputKey.text);

        //計算金鑰
        string key = AuthHelper.ToMD5(TextKey.text);
        Debug.Log("key = " + key);

        //比對金鑰
        if (InputKey.text.Equals(key))
        {
            Debug.Log("SAME!");
            Application.LoadLevel(1);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}