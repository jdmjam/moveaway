using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerManager : MonoBehaviour,TakeAHit     {
    

    public void TakeAHit(bool hit)    {
        Destroy(gameObject);
    }

}
