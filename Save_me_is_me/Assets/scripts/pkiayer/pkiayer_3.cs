using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer_3 : MonoBehaviour
{
    public float speed;

    // Use this for initialization
    private void Start()
    {
        speed = 3f;
    }

    // Update is called once per frame
    //FixedUpdate固定更新
    private void Update()//每一貞
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);//速度*時間=位置,(x,y,z),貞數越高deltaTime越低好
        //addForce(0,0,0)
    }
}