using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderControl2 : MonoBehaviour

{
    public GameObject boulder;
    public GameObject spawnedBoulder;


    // this code controls where the ball spawner moves when keys are pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x < 24)
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x > -24)
        {
            transform.Translate(-1, 0, 0);
        }
        // will spawn a new boulder when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroys the boulder and respawns it
            Destroy(spawnedBoulder);
             spawnedBoulder = Instantiate(boulder);
            spawnedBoulder.transform.position = transform.position;
        }
    }
}

