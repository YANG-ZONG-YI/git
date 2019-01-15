using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class destroy : MonoBehaviour
{
    private float DestroyTime = 0.1f;

    private void OnCollisionEnter(Collision collision)//碰撞器
    {
        Debug.Log(collision.collider.tag);//印名子或標籤
        if (collision.collider.tag == "unitychan")
        {
            Destroy(gameObject, DestroyTime);//刪除(物,時間)
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        //Destroy(gameObject, DestroyTime);//刪除(物,時間)
    }

    // Update is called once per frame
    private void Update()
    {
    }
}