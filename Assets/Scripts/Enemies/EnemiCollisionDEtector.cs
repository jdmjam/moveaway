using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiCollisionDEtector : MonoBehaviour
{
    [SerializeField] private LayerMask enemieLayerMask;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        int objectLayer = collision.gameObject.layer;
        if ((enemieLayerMask&(1<<objectLayer))>0)
        {
            Destroy(gameObject);
        }
    }
}
