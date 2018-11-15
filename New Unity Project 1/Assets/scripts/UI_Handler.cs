using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour {

    #region //UI Setting Config (Name)
    private const string TITLE_NAME = "Title";
    #endregion

    private Text textTitle { get; set; }
    private Text textMessage { get; set; }

    private Button  btnyes { get; set; }
    private Text textyes { get; set; }

    private Button btnno { get; set; }
    private Text textno { get; set; }

    private void Awake()
    {
        ScanObject();

        InitObject();
    }

    private void ScanObject()
    {
        try
        {
            #region //Scan
            int childCount = this.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = this.transform.GetChild(i).gameObject;
                Debug.Log("Child Index = " + 1 + "Name = " + go.name);

                if (go.name.Equals("Title"))
                {
                    textTitle = go.GetComponent<Text>();
                }
                if (go.name.Equals("Message"))
                {
                    textMessage = go.GetComponent<Text>();
                }
                if (go.name.Equals("BtnRight"))
                {
                    btnyes = go.GetComponent<Button>();
                    textyes = go.GetComponentInChildren<Text>(); //最短模式      
                }
                if (go.name.Equals("BtnLeft"))
                {
                    btnno = go.GetComponent<Button>();
                    textno = go.GetComponentInChildren<Text>(); //最短模式      
                }

            }
            #endregion
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    private void InitObject()
    {
        try
        {
            #region //init
            if (textTitle != null)
            {
                textTitle.text = "I M Right!";
            }
            if (textMessage != null)
            {
                textMessage.text = "This is testing text\ntesting player 1 \ntesting player 2";
            }
            #endregion
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }

    }

    public  void SetTitle(string title)
    {
        try
        {
            textTitle.text = title;
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

}
