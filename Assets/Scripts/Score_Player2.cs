using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Player2 : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score_p2;


    // Start is called before the first frame update
    void Start()
    {
        score_p2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score_p2.text = "" + scoreValue;
    }
}
