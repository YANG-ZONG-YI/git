using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITEXT : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    private float number = 0;
    public bool t = false;

    private void OnCollisionEnter(Collision collision)//碰撞器
    {
        Debug.Log(collision.collider.tag);//印名子或標籤
        if (collision.collider.tag == "unitychan")
        {
            Debug.Log("666");
            number = Random.Range(-100, 100);
            t = true;
        }
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        set_allstate_false();
        //Debug.Log(player.position.z);
        if (t == true)
        {
            number = number + player.position.z;//.ToString("0")
        }
        ScoreText.text = "分數:" + player.position.z + number;
    }

    private void set_allstate_false()
    {
        t = false;
    }
}