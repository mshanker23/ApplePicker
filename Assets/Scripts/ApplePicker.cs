﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{

    [Header("Set In Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomy = -14f;
    public float basketSpacingy = 2f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<numBaskets; i++)
        {
            GameObject tBasketGo = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomy + (basketSpacingy * i);
            tBasketGo.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
