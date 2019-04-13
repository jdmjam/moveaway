using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : PlayerManager
{
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    //0.94
    private float startingXPosition = -0.82f;
    private float startingYPosition = -4.3f;
    private bool isInLeftPosition = true;
    private bool isInRightPosition = false;

    [SerializeField] private float endingXPosition = 0.94f;
    [SerializeField] private float endinfYPosition = -4.3f;

   
    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow) && (isInLeftPosition == true))
        {
            isInLeftPosition = false;
            isInRightPosition = true;
            return;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && (isInRightPosition == true))
        {
            isInLeftPosition = true;
            isInRightPosition = false;
            return;
        }
    }

    private void FixedUpdate()
    {
        //teleport
        if ((isInRightPosition == true) && (isInLeftPosition == false))
        {
            transform.position = new Vector2(endingXPosition, endinfYPosition);
        }

        if ((isInRightPosition == false) && (isInLeftPosition == true))
        {
            transform.position = new Vector2(startingXPosition, startingYPosition);
        }
    }
}
