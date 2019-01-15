using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkiayer_5 : MonoBehaviour
{
    public Camera main_camear;
    public Ray ray;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))//左0 右1
        {
            ray = main_camear.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);//滑鼠點到的位置
            RaycastHit[] raycasthit = Physics.RaycastAll(ray, 50);//光線碰撞物件收集和範圍
            for (int i = 0; i < raycasthit.Length; i++)
            {
                print(raycasthit[i].collider.tag);
                print(raycasthit[i].point);
            }
        }
    }
}