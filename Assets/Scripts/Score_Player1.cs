using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Player1 : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score_p1;


    // Start is called before the first frame update
    void Start()
    {
        score_p1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score_p1.text = "" + scoreValue;
    }
}
