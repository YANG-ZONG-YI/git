using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FristHandler : MonoBehaviour {

    public Button btnStart;
	// Use this for initialization
	void Start ()
    {
        if (btnStart != null)
        {
            btnStart.gameObject.SetActive(false);
        }
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
