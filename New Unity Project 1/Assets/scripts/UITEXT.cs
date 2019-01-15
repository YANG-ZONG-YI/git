using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITEXT : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(player.position.z);
        ScoreText.text = "分數:" + player.position.z.ToString("0");
    }
}