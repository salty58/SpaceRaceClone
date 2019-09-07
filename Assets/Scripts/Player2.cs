using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //float speed = 2.5f;
    Vector3 startPos;
    float timer = 95f;
    float accel = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, accel, 0);

        if (Input.GetKey(KeyCode.UpArrow) && timer > 0f)
        {
            //transform.Translate(0, Time.deltaTime * speed, 0);
            accel += 0.001f;
            if(accel > 0.1f)
            {
                accel = 0.1f;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow) && timer > 0f)
        {
            //transform.Translate(0, Time.deltaTime * -speed, 0);
            accel -= 0.001f;
            if (accel < -0.1f)
            {
                accel = -0.1f;
            }
        }

        if (transform.position.y > 5.18f)
        {
            transform.position = startPos;
            Score_Player2.scoreValue += 1;
            accel = 0f;
        }

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            transform.position = startPos;
            accel = 0f;
        }

        if(transform.position.y < -4.32f)
        {
            transform.position = startPos;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("Hello");
            transform.position = startPos;
            accel = 0f;
        }
    }
}
