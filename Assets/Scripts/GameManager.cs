using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : SingletonBehaviour<GameManager> {


    //Cars to choose from.
    public string carSelected;

    //Trigger Bools

    //CrashScene
    public bool CrashTrigger1 = false;
    public bool CrashTrigger2 = false;
    public bool CrashTrigger3 = false;
    public bool CrashTrigger4 = false;
    public GameObject Ctrigger1;
    public GameObject Ctrigger2;
    public GameObject Ctrigger3;

    //DrivingScene
    public bool DrivingTrigger1 = false;
    public bool DrivingTrigger2 = false;
    public bool DrivingTrigger3 = false;
    public bool DrivingTrigger4 = false;
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;


    //The 4 directions you can move in.
    public string forwardC,
                  backwardC,
                  leftC,
                  rightC;

    public GameObject GameManagerObject;



    //The different keys that the Failsecure system can change your controls to.


    void Start() {
        //Initial set controls to WASD.
        forwardC = "w";
        backwardC = "s";
        leftC = "a";
        rightC = "d";

        DontDestroyOnLoad(this.gameObject);

        
    }

    void Update() {
//driving triggers deleting
     if(DrivingTrigger1 == true)
        {

            Destroy(trigger1);

        }

        if (DrivingTrigger2 == true)
        {

            Destroy(trigger2);

        }

        if (DrivingTrigger3 == true)
        {

            Destroy(trigger3);

        }

        if (DrivingTrigger4 == true)
        {

            Destroy(trigger4);

        }

        //crash triggers deleting

        if (CrashTrigger1 == true)
        {

            Destroy(Ctrigger1);

        }

        if (CrashTrigger2 == true)
        {

            Destroy(Ctrigger2);

        }

        if (CrashTrigger3 == true)
        {

            Destroy(Ctrigger3);

        }

    }

    //When reassigning controls,


  



}