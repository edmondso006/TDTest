using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int score;
    private Text input;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        input = GameObject.Find("Canvas").GetComponentInChildren<Text>();
        input.text = ("Score: " + score.ToString());
    }
}