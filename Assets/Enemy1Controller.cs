using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    [SerializeField]private float speed=3f;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerManager>().TakeAHit();

        }

        Destroy(gameObject);
    }

    private void Update(){

        transform.Translate(Vector2.Down*speed*Time.deltaTime);
    }
}
