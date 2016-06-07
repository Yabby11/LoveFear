using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    Transform car;
    public float moveSpeed = 0.0f;
    public float maxSpeed = 8f;
    public float rotateSpeed = 50.0f;
    public float acceleration = 10.0f;


    //TriggerZones
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;


    Vector3 startingPos;


    public GameObject supra;
                

    public CameraController camController;
    public Rigidbody rb;

  

    void Start() {
        rb = GetComponent<Rigidbody>();
        car = this.transform;
        startingPos = car.position;
     
    }
    

    void Update() {
        Movement();

       
    }


    void Movement() {
        
            rb.position += transform.forward * moveSpeed * Time.deltaTime;
            //Movement Up and Down
            if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.S)) {
                if (moveSpeed > 0.05f) {
                    moveSpeed -= Time.deltaTime * acceleration;
                } else if (moveSpeed < 0.05f) {
                    moveSpeed += Time.deltaTime * acceleration;
                } else if (moveSpeed > -0.05f && moveSpeed < 0.05f) {
                    //MASSIVE SKIDDIES
                }

            } else if (Input.GetKey(KeyCode.W)) {
                if (moveSpeed < maxSpeed) {
                    if (moveSpeed < 0.0f) {
                        moveSpeed += Time.deltaTime * acceleration;
                    } else {
                        moveSpeed += Time.deltaTime * 2;
                    }
                }

            } else if (Input.GetKey(KeyCode.S)) {
                if (moveSpeed > -maxSpeed) {
                    if (moveSpeed > 0.0f) {
                        moveSpeed -= Time.deltaTime * acceleration;
                    } else {
                        moveSpeed -= Time.deltaTime * 2;
                    }
                }

            } else if (moveSpeed > 0.0f) {
                moveSpeed -= Time.deltaTime * 4;

            } else if (moveSpeed < 0.0f) {
                moveSpeed += Time.deltaTime * 4;
            }

            if (Input.GetKey(KeyCode.A)) {
                car.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * (moveSpeed * 9));
            } else if (Input.GetKey(KeyCode.D)) {
                car.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * (moveSpeed * 9));
            }
        }

    void OnTriggerEnter(Collider Other)
    {
        
    if(Other.gameObject == (trigger1))
        {
            GameManager.Instance.DrivingTrigger1 = true;
            Destroy(trigger1);
            SceneManager.LoadScene(1);

        }
        if (Other.gameObject == (trigger2))
        {
            GameManager.Instance.DrivingTrigger2 = true;
            Destroy(trigger2);
            SceneManager.LoadScene(1);
        }
        if (Other.gameObject == (trigger3))
        {
            GameManager.Instance.DrivingTrigger3 = true;
            Destroy(trigger3);
            SceneManager.LoadScene(1);
        }
        if (Other.gameObject == (trigger4))
        {
            GameManager.Instance.DrivingTrigger4 = true;
            Destroy(trigger4);
            SceneManager.LoadScene(1);
        }





        


    }
    }

    

   
 
