using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer_7 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Use this for initialization
    //private void Start()
    // {
    //}

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position + offset;//保持距離跟隨
    }
}