﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer_4 : MonoBehaviour
{
    public Animator anim;
    public bool GoF;//布林函數
    public bool GoR;
    public bool GoL;
    public float speed;

    // Use this for initialization
    private void Start()
    {
        anim = GetComponent<Animator>();//抓取
        GoF = true;
        GoR = false;
        GoL = false;
        speed = 3f;
    }

    // Update is called once per frame
    private void Update()
    {
        //Input.GetKeyUp放開
        //Input.GetKey按著
        //GetKeyDown按下
        if (Input.GetKeyDown("w"))
        {
            set_allstate_false();
            GoF = true;
        }
        if (Input.GetKeyDown("d"))
        {
            set_allstate_false();
            GoR = true;
        }
        if (Input.GetKeyDown("a"))
        {
            set_allstate_false();
            GoL = true;
        }
        if (GoF == true)
        {
            moving(speed);
        }
        anim.SetBool("GoF", GoF);//送出
        anim.SetBool("GoR", GoR);
        anim.SetBool("GoL", GoL);
    }

    private void set_allstate_false()
    {
        GoF = false;
        GoR = false;
        GoL = false;
    }

    private void moving(float speed)
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);//
    }
}