using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;

public class PplayerMovement : MonoBehaviour
{
    //public static Action<string> PlayerCollectsCoin = delegate { };

    //Private Accessors
    private Animator animator;
    private Rigidbody rgbody;
  
    private Vector3 move;
    
    private Touch myTouch;
    private Vector3 limit;

    private Touch _touch;
    private bool _firstTouch = false;

    //private string waterOrbsScore = null;
    //public TextMesh Text = null;


    //Public Accessors


    public float turnSpeed;
    public float speed;

    public int Force; // Force applied to move the player forward

    public GameObject endScreen; //For gameover & restart button to show
    public int points = 0; //for Orbs collection points

    private float winNumber = 13.0f;



    // Start is called before the first frame update


    void Start()
    {
        animator = GetComponent<Animator>(); // get animator to play animation
        rgbody = GetComponent<Rigidbody>(); //  Added rigid body to apply force on

      
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.touchCount > 0) //If there is touch
        {
            myTouch = Input.GetTouch(0);

            if (myTouch.phase == TouchPhase.Moved)
            {
                // transform.position = new Vector3(transform.position.x + myTouch.deltaPosition.x * turnSpeed, transform.position.y, transform.position.z);
                limit = new Vector3(transform.position.x + myTouch.deltaPosition.x * turnSpeed, transform.position.y, transform.position.z);
                Debug.Log(limit.x);
                if (limit.x >= -24.98 && limit.x <= -16.82) // Tells the maximum cordinates on x axis the palyer should go when going both left and right
                {
                    Debug.Log("in");
                    transform.position = limit; //Move player to maximum position on which the limit is set
                }
            }
        }


       
    }

    private void OnTriggerEnter(Collider other) //For player death by collidig with enemy Colliders
    {
        if (other.CompareTag("Ghost"))
        {
            
            GameEndPoint(other);
            endScreen.SetActive(true);
            //to restart & gameover button

        }

    }

    void GameEndPoint(Collider Player)
    {
        if (points != winNumber)
        {
            Destroy(gameObject);
        }

    }

    private void OnGUI()

    {
        //if (gameObject.CompareTag("WaterOrbs"))
        //{
            GUI.Label(new Rect(10, 10, 100, 20), "SnowOrbs : " + points);
        //string text = points.ToString();
        //waterOrbsScore = text;
        //T

        //GUI.Label(new Rect(10, 10, 100, 20), "SnowOrbs : " + points);


        //}



        //if (gameObject.CompareTag("MonsterOrbs"))
        //{
        //    GUI.Label(new Rect(5, 5, 100, 20), "Monster Power Orbs : " + points);

        //}

    }
    void FixedUpdate()
    {
        rgbody.AddForce(Vector3.forward * speed * -1, ForceMode.Impulse); // Multiplyin by -1 to move player forward on z axis according to our setting
        animator.SetBool("isMoving", true); // The player is moving forward
    }
}
