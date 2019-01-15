using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawn : MonoBehaviour
{
    public Transform[] player;
    public Transform[] spawnPoints;
    public GameObject[] Items;
    public float spawnTime = 5.5f;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("spawnItems", 0, spawnTime);//(名,始時間,每秒)
    }

    // Update is called once per frame
    private void Update()
    {
        //StopCoroutine()結束
    }

    private void spawnItems()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);//亂數(始,末陣列長)
        int ItemsIndex = Random.Range(0, Items.Length);
        Instantiate(Items[ItemsIndex], spawnPoints[spawnIndex].position);//rotation旋轉
    }

    private void Instantiate(GameObject gameObject, Vector3 position)
    {
        throw new NotImplementedException();
    }
}