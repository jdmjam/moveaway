using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Controller : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    //-2.5
    private float startingXPosition = -4.26f;
    private float startingYPosition = -4.3f;
    private bool isInLeftPosition = true;
    private bool isInRightPosition = false;
    
    [SerializeField] private float endingXPosition = -2.5f;
    [SerializeField] private float endinfYPosition = -4.3f;

    public void TakeAHit()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    private void Awake() {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
      
    }

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&(isInLeftPosition==true))    {
            isInLeftPosition = false;
            isInRightPosition = true;
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (isInRightPosition == true))
        {
            isInLeftPosition = true;
            isInRightPosition = false;
            return;
        }
    }

    private void FixedUpdate()    {
        //teleport
        if ((isInRightPosition==true)&&(isInLeftPosition==false))    {
            transform.position = new Vector2(endingXPosition,endinfYPosition);
        }

        if ((isInRightPosition == false) && (isInLeftPosition == true))
        {
            transform.position = new Vector2(startingXPosition, startingYPosition);
        }
    }
}
