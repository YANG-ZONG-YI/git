using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer_8 : MonoBehaviour
{
    public pkiayer_4 pkiayer_4;

    private void OnCollisionEnter(Collision collision)//碰撞器
    {
        Debug.Log(collision.collider.tag);//印名子或標籤
        if (collision.collider.tag == "cube")
        {
            Debug.Log("666");
            pkiayer_4.enabled = false;
        }
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}