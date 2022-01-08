﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(50 * target.transform.localScale.x, 1, 100);

        }
    }
}
