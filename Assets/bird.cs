using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bird : MonoBehaviour
{
    public Rigidbody2D rb;

    public float force;

    public float score;

    public TextMeshProUGUI score_text;

    public Vector3 direction;

    public float fall_speed;

    public float jump_strenght;

         

            
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

       

    }

    
    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;

           // rb.velocity = new Vector2(rb.velocity.x, 1 * jump_strenght * Time.deltaTime);


            rb.velocity = Vector2.up * jump_strenght * Time.deltaTime;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 50.0f);

            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    rb.velocity = Vector2.up * jump_strenght * Time.deltaTime;
                }
            }
                   
        }

        transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, fall_speed);

        /* if (Input.GetMouseButtonUp(0))
         {
             mouse_down = false;
         }

         if (transform.eulerAngles.z > -60.0f && transform.eulerAngles.z <= 60.0f && mouse_down == false) 
         {
             transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, fall_speed);
             Debug.Log("jdnads");

        } */




        //      rb.AddForce(Vector3.up * force);



    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Game Over");

            FindObjectOfType<GameManager>().GameOver();

            

        }


        if (collision.gameObject.tag == "Scoring")
        {
            

            score += 1;

            score_text.text = score.ToString();


        }
    }

    
}
