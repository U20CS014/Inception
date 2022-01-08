using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f5 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.F5))
        {
            UiObject.SetActive(true);
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(10 * target.transform.localScale.x, 1, 100);
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            UiObject.SetActive(false);
        }

    }
}
