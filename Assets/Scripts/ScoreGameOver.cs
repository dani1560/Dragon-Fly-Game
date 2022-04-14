using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGameOver : MonoBehaviour
{
    Text scoreCard;

    // Start is called before the first frame update
    void Start()
    {
        scoreCard = GameObject.Find("ScoreNo").GetComponent<Text>();
        scoreCard.text = ScoreCount.scoreCount.ToString();
    }

  
}
