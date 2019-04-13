using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : PlayerManager, TakeAHit
{
    //[SerializeField] private float decreasementPosition = 3.0f;
    private Rigidbody2D myRigidbody2D;
    private Animator myAnimator;
    //private float initialPosition = 0.0f;
    //private float lastPosition = 0.0f;
    [SerializeField] private Transform initalPosition;
    private bool isInLeftPosition = true;
    //private bool isInRightPosition = false;

    public void TakeAHit(bool hit)
    {
        Destroy(gameObject);
    }

    private void Awake() {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        //  lastPosition = initialPosition - decreasementPosition;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)/*||*/)        {
            //StartCoroutine(Move());
            if (isInLeftPosition) {
                Vector2 myNewPosition = new Vector2(initalPosition.position.x + 1.7f, initalPosition.position.y);
                isInLeftPosition = false;
            } else if(!isInLeftPosition)   {
                Vector2 myNewPosition = new Vector2(initalPosition.position.x - 1.7f, initalPosition.position.y);
                isInLeftPosition = true;
            }
        }
    }

   /* private IEnumerator Move() {
        while (transform.position.x!=lastPosition) {
            Vector3 velocity = Vector3.right;
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(lastPosition, transform.position.y, transform.position.z), ref velocity, 0.5f);
            yield return new WaitForEndOfFrame();
        }
        lastPosition = (lastPosition != initialPosition) ? initialPosition : initialPosition - decreasementPosition;
    }*/
}
