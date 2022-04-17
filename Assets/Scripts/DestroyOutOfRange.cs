using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfRange : MonoBehaviour
{

    private int topRange;
    private int downRange;

    // Start is called before the first frame update
    void Start()
    {
        topRange = 30;
        downRange = -5;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topRange) Destroy(gameObject);
        else if (transform.position.z < downRange) {
            Debug.Log("Game Over");
            Destroy(gameObject);
            
        } 
        
    }
}
