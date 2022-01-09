# Inception
In an ever changing world that’s constantly in competition with itself, one of things that’s strangely stayed the same is the education system. Now that everybody’s transitioning into, what feels like, a semi online life, it’s only fitting that we refine our ways of tutoring. This is where VR for education comes in.  

![vr1](https://user-images.githubusercontent.com/76207294/148668507-18127a48-a7c4-4eff-a848-1fd38535f420.jpeg)

VR creates an immersive environment that allows individuals to fully indulge themselves into their field of interest. No more protests from students complaining about how textbooks with endless words tire them out, or how they can't visualize the study material. With VR, words on the page come to life. Be it learning a new language, about the vast endlessness of the universe or looking into the mysteries of your own body, VR learning makes everything simpler.   

Studies confirm visual learning improves retention of information, the additive pleasure of being in an immersive online environment is the icing on the cake.   

Making use of programming language C#, we allow the user to interact with the virtual environment and take in all the information at their own pace. No more pacing back and forth trying to memorize words in a book, the words take shape around you instead. And in this case, the WORLD takes shape around you, as this project allows you to conquer space from the confines of where you decide to sit. 


# How it works:

Making use of the software 'Unity' and the programming language C#, we've created a 3d model of the solar system and select constellations. The user interface allows the individual to surf through the different planets by clicking through the command keys F1 - F8. Based on the key you press, the respective planet shows up displaying along with it, its name and some important information related to it. F10 command lets the user watch the movement of planets devoid of information texts.


![solar](https://user-images.githubusercontent.com/76207294/148669553-77a8e67a-a74a-431c-9cac-80ea40627ee0.jpeg)



The 'Change Scene' button at the bottom right corner of the screen allows the user to shift from viewing the solar system to a display of three constellations — Orion, Aries and Leo. 


![consteallation](https://user-images.githubusercontent.com/76207294/148669578-19052aa9-0cb1-4630-b6e0-9ac59167a465.jpeg)



KEYS:

F1 - Mercury
F2 - Venus
F3 - Earth
F4 - Mars
F5 - Jupiter
F6 - Saturn 
F7 - Uranus
F8 - Neptune
F9 - Solar System (TOP VIEW)
F10 - Clear Info 
Change Scene - Shift from Solar System to Constellations


![Earth](https://user-images.githubusercontent.com/76207294/148669670-1cf140e0-2420-4410-a15c-89921de94ae8.jpeg)



# CODES:

# //Rotating The Planets

using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Transform target; 
	public int speed; 
	
	void Start() {
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	void Update () {
		transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
	}
}

# //Looking At Target
using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; 

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	
	void OnMouseDown () {
		
		LookAtTarget.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(1 * target.transform.localScale.x, 1, 100);
	}
}

# //F1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f1 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
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

# //F2
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f2 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
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


# //F3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f3 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
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

# //F4 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f4 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F4))
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

# //F5
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f5 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
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

# //F6
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f6 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F6))
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

# //F7
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f7 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F7))
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

# //F8
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f8 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;
    
    
    void Start()
    {
       UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8))
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

# //F9
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class f9 : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject target;

    
    
    void Start()
    {
        UiObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            UiObject.SetActive(true);
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(30 * target.transform.localScale.x, 1, 100);
            
        }  

        if (Input.GetKeyDown(KeyCode.F10))
        {
            UiObject.SetActive(false);
        }

    }

}

# //For Changing Scene
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   
    
    public void NewScene()

    {
        SceneManager.LoadScene("Constellations");
    }
}

 # //function (scene change)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene (name);
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

# //Line Animator
using UnityEngine ;
using System.Collections ;

public class LineAnimator : MonoBehaviour {
   [SerializeField] private float animationDuration = 5f ;

   private LineRenderer lineRenderer ;
   private Vector3[] linePoints ;
   private int pointsCount ;

   private void Start () {
      lineRenderer = GetComponent<LineRenderer> () ;

      
      pointsCount = lineRenderer.positionCount ;
      linePoints = new Vector3[pointsCount] ;
      for (int i = 0; i < pointsCount; i++) {
         linePoints [ i ] = lineRenderer.GetPosition (i) ;
      }

      StartCoroutine (AnimateLine ()) ;
   }

   public IEnumerator AnimateLine () {
      float segmentDuration = animationDuration / pointsCount ;

      for (int i = 0; i < pointsCount - 1; i++) {
         float startTime = Time.time ;

         Vector3 startPosition = linePoints [ i ] ;
         Vector3 endPosition = linePoints [ i + 1 ] ;

         Vector3 pos = startPosition ;
         while (pos != endPosition) {
            float t = (Time.time - startTime) / segmentDuration ;
            pos = Vector3.Lerp (startPosition, endPosition, t) ;

            
            for (int j = i + 1; j < pointsCount; j++)
               lineRenderer.SetPosition (j, pos) ;

            yield return null ;
         }
      }
   }
}
                                                
# //Constellations - Orion
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O : MonoBehaviour
{
    public GameObject target;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(50 * target.transform.localScale.x, 1, 100);
        }
    }
}

# //Constellations - Aries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public GameObject target;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(50 * target.transform.localScale.z, 1, 100);
        }
    }
}
                                                
# //Constellations - Leo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L : MonoBehaviour
{
    public GameObject target;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LookAtTarget.target = target;
            Camera.main.fieldOfView = Mathf.Clamp(50 * target.transform.localScale.x, 1, 100);

        }
    }
}                                                
