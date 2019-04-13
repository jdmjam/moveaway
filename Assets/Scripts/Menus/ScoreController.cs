using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int ScoreValue = 0;
    private float score;

    [SerializeField] private Text textScore;
  

    private void Update()
    {
        score += ScoreValue + Time.timeScale;
        textScore.text = score.ToString();
    }
}
