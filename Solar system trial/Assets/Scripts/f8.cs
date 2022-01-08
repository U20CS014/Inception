using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f8 : MonoBehaviour
{
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8))
        {
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(10 * target.transform.localScale.x, 1, 100);
        }
    }
}
