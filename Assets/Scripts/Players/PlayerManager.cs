using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class PlayerManager : MonoBehaviour {

    [SerializeField] private GameObject[] player;


    public void TakeAHit()
    {

       

        for (int i = player.Length-1; i >= 0; i--)
        {
            Destroy(player[i].gameObject);
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
