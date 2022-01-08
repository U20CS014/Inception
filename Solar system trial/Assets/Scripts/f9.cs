using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f9 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;

    
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            UiObject.SetActive(true);
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(20 * target.transform.localScale.x, 1, 100);
            
        }        

    }

}

