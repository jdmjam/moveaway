using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : PlayerManager
{
    private Rigidbody2D myRigidbody2D;

    [SerializeField] private Transform initiaLPosition;
    [SerializeField] private Transform lastPosition;
    

    private void Awake()    {
        
    }
}
