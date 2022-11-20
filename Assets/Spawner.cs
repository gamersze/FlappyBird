using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefabPipe;

    public float minHeight = -4.24f;
    public float maxHeight = 0.22f;



    void Start()
    {
        InvokeRepeating("add_prefab", 1f, 1.5f);
    }
   

    void add_prefab()
    {
        float rast = Random.Range(minHeight, maxHeight);
        GameObject new_prefab = Instantiate(prefabPipe, new Vector3(transform.position.x, rast, transform.position.z), Quaternion.identity);


    }

    void Update()
    {
        
    }
}
