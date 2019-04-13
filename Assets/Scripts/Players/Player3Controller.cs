using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Controller : PlayerManager
{
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    //4.2
    private float startingXPosition = 2.6f;
    private float startingYPosition = -4.3f;
    private bool isInLeftPosition = true;
    private bool isInRightPosition = false;

    [SerializeField] private float endingXPosition = 4.2f;
    [SerializeField] private float endinfYPosition = -4.3f;

    

    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && (isInLeftPosition == true))
        {
            isInLeftPosition = false;
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && (isInLeftPosition == false))
        {
            isInLeftPosition = true;
            return;
        }
    }

    private void FixedUpdate()
    {
        //teleport
        if (isInLeftPosition == false)
        {
            transform.position = new Vector2(endingXPosition, endinfYPosition);
        }

        if (isInLeftPosition == true)
        {
            transform.position = new Vector2(startingXPosition, startingYPosition);
        }
    }
}
