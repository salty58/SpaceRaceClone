using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //float speed = 2.5f;
    Vector3 startPos;
    Vector3 currentPos;
    float timer = 95f;
    float accel = 0f;
    float xMove = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position;

        transform.Translate(0, accel, 0);

        if (Input.GetKey(KeyCode.W) && timer > 0f)
        {
            //transform.Translate(0, Time.deltaTime * speed, 0);
            accel += 0.0025f;
            if(accel > 0.1f)
            {
                accel = 0.1f;
            }
        }
        else if (Input.GetKey(KeyCode.S) && timer > 0f)
        {
            //transform.Translate(0, Time.deltaTime * -speed, 0);
            accel -= 0.0025f;
            if(accel < -0.1f)
            {
                accel = -0.1f;
            }
        }

        if (Input.GetKey(KeyCode.A) && timer > 0f)
        {
            transform.Translate(-xMove, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) && timer > 0f)
        {
            transform.Translate(xMove, 0, 0);
        }

        if (transform.position.y > 5.18f)
        {
            transform.position = startPos;
            Score_Player1.scoreValue += 1;
            Asteroid_Right.speed += 0.5f;
            Astroid_Left.speed += 0.5f;
            accel = 0f;
        }

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            transform.position = startPos;
            accel = 0f;
        }

        if (transform.position.y < -4.32f)
        {
            transform.position = currentPos;
            accel = 0f;
        }

        if(transform.position.x < -8.41 || transform.position.x > -0.56)
        {
            transform.position = currentPos;
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
