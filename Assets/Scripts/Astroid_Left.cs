using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid_Left : MonoBehaviour
{
    public float speed = 1.5f;
    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * -speed, 0, 0);


        if(transform.position.x < -9.05f)
        {
            transform.position = startPos;
        }
    }
}
