using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI2_Handler : MonoBehaviour
{
    #region //UI Setting Config (Name)

    private const string TITLE_NAME = "Title";

    #endregion //UI Setting Config (Name)

    private Text TextTitle { get; set; }
    private Text TextMessage { get; set; }

    private Button BtnYes { get; set; }
    private Text TextYes { get; set; }

    private Button BtnNo { get; set; }
    private Text TextNo { get; set; }

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
                    TextTitle = go.GetComponent<Text>();
                }
                if (go.name.Equals("Message"))
                {
                    TextMessage = go.GetComponent<Text>();
                }
                if (go.name.Equals("BtnYes"))
                {
                    BtnYes = go.GetComponent<Button>();
                    TextYes = go.GetComponentInChildren<Text>(); //最短模式
                }
                if (go.name.Equals("BtnNo"))
                {
                    BtnNo = go.GetComponent<Button>();
                    TextNo = go.GetComponentInChildren<Text>(); //最短模式
                }
                if (TextNo != null)
                {
                    TextNo.text = "否";
                }
            }

            #endregion //Scan
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

            if (TextTitle != null)
            {
                TextTitle.text = "I M Right!";
            }
            if (TextMessage != null)
            {
                TextMessage.text = "這個是測試的文字\n換行測試\n換行測試2";
            }
            if (TextYes != null)
            {
                TextYes.text = "OK";
            }
            if (TextNo != null)
            {
                TextNo.text = "否";
            }
            if (BtnNo != null)
            {
                BtnNo.gameObject.SetActive(false);
            }

            #endregion //init
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    public void SetTitle(string title)
    {
        try
        {
            TextTitle.text = title;
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }
}