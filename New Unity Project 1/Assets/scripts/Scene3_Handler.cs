using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_Handler : MonoBehaviour
{
    public GameObject canvas = null;
    private UI2_Handler messageBox = null;

    // Use this for initialization
    private void Start()
    {
        InitObject();
        CheckObject();
    }

    private void CheckObject()
    {
        try
        {
            GameObject _prefab = Resources.Load<GameObject>("Prefabs\\MessageBox");

            if (_prefab != null)
            {
                GameObject obj = Instantiate(_prefab);
                if (canvas != null)
                {
                    obj.transform.parent = canvas.transform;                    // B.tf.parent = A.tf  //B在A裡面
                    obj.transform.localPosition = Vector3.zero;
                    messageBox = obj.GetComponent<UI2_Handler>();
                }
            }
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
            if (messageBox != null)
            {
                messageBox.SetTitle("我在場景中設定東西!!!!");
            }
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}