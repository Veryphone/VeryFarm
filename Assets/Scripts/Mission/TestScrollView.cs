﻿using UnityEngine;
using System.Collections;

public class TestScrollView : MonoBehaviour {
    Transform dialogMain;
    Transform bgBlack;
	// Use this for initialization
    ArrayList arr;
	void Start () {
        dialogMain = transform.FindChild("Main");
        bgBlack = transform.FindChild("BgBlack");
        arr = new ArrayList();
        for (int i = 0; i < dialogMain.FindChild("Scroll View").FindChild("Grid").childCount; i++ )
        {
            arr.Add(dialogMain.FindChild("Scroll View").FindChild("Grid").GetChild(i));
        }
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log((arr[0] as Transform).position.y);
        for (int i = 0; i < arr.Count; i++ )
        {
            Transform tf = arr[i] as Transform;
            if (tf.position.y > 1 || tf.position.y < -1)
            {
                tf.gameObject.SetActive(false);
            }
            else
            {
                tf.gameObject.SetActive(true);
            }
        }
	}
}
