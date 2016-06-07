using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FPSControllerCol : MonoBehaviour {

    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;


    // Use this for initialization
    void Start () {

        trigger1 = GameObject.FindGameObjectWithTag("trigger1");
        trigger2 = GameObject.FindGameObjectWithTag("trigger2");
        trigger3 = GameObject.FindGameObjectWithTag("trigger3");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider Other)
    {

        if (Other.gameObject == (trigger1))
        {
            GameManager.Instance.CrashTrigger1 = true;
            Destroy(trigger1);
           SceneManager.LoadScene(0);

        }
        if (Other.gameObject == (trigger2))
        {
            GameManager.Instance.CrashTrigger2 = true;
            Destroy(trigger2);
         SceneManager.LoadScene(0);
        }
        if (Other.gameObject == (trigger3))
        {
            GameManager.Instance.CrashTrigger3 = true;
            Destroy(trigger3);
           SceneManager.LoadScene(0);
        }
      
        }
    }
