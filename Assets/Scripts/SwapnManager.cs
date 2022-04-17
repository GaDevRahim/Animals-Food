using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalsList;
    private int xRange = 13;
    private int zPos = 25;
    private int whichAnimal;
    private float randomPosX;
    private Vector3 pos = new Vector3(0, 0, 0);

    private float startTime = 2.0f;
    private float timeToRepeating = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GetRandomAnimal", startTime, timeToRepeating);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetRandomAnimal();
        } */
    }
    void GetRandomAnimal()
    {
        whichAnimal = Random.Range(0, animalsList.Length);
        randomPosX = Random.Range(-xRange, xRange + 1);
        pos.Set(randomPosX, 0, zPos);

        Instantiate(animalsList[whichAnimal], pos, animalsList[whichAnimal].transform.rotation);
    }
}
