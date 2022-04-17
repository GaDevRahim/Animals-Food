using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed;
    private float max_Xrange;

    public GameObject projectileFood;

    // Start is called before the first frame update
    void Start()
    {
        speed = 12.0f;
        max_Xrange = 13.0f;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (transform.position.x < -max_Xrange) transform.position = new Vector3(-max_Xrange, transform.position.y, transform.position.z);
        if (transform.position.x > max_Xrange)  transform.position = new Vector3(max_Xrange, transform.position.y, transform.position.z);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileFood, transform.position, projectileFood.transform.rotation);
        }

    }
}
