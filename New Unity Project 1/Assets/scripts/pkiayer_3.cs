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
    private void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);//速度*時間=位置,(x,y,z)
    }
}