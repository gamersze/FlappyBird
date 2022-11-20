using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeObstacle : MonoBehaviour
{
    public GameObject pipe;

    private float leftEdge;


    void Start()
    {

        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 20f;

        


    }

    
    void Update()
    {
        if (GameManager.isPlaying)
        {
            
            
            transform.Translate(new Vector3(-GameManager.hiz * Time.deltaTime, 0, 0));

           if(transform.position.x < leftEdge)
            {
                Destroy(gameObject);

            }

        }
        

        
       
    }

   
}
