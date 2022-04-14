using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    Text score;
    public static int scoreCount;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Text>();
        InvokeRepeating("scoreIncrement", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = scoreCount.ToString();
    }
    void scoreIncrement() {

        scoreCount++;

    }
}
