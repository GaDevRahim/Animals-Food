using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfRange : MonoBehaviour
{
    private int topRange;
    private int downRange;

    void Start()
    {
        topRange = 30;
        downRange = -5;
    }

    void Update()
    {
        if (transform.position.z > topRange) Destroy(gameObject);
        else if (transform.position.z < downRange) {
            Debug.Log("Game Over");
            Destroy(gameObject);    
        } 
    }
}
