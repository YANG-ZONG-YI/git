using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer : MonoBehaviour
{
    public Animator anim;//所有人使用設定

    // Use this for initialization
    private void Start()//私人使用
    {
        anim = GetComponent<Animator>();//Animator的控制
    }

    // Update is called once per frame
    private void Update()
    {
        //Input.GetKeyUp放開
        //Input.GetKey按著
        //GetKeyDown按下
        if (Input.GetKeyDown("w"))
        {
            anim.Play("GoF");//播放
        }
        if (Input.GetKeyDown("a"))
        {
            anim.Play("GoR");
        }
        if (Input.GetKeyDown("d"))
        {
            anim.Play("GoL");
        }
    }
}