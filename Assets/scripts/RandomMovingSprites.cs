using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class RandomMovingSprites : MonoBehaviour {

    [SerializeField]
    GameObject prefabMovingSprite0;
    [SerializeField]
    GameObject prefabMovingSprite1;
    [SerializeField]
    GameObject prefabMovingSprite2;

    // timing support
    const float ChangeDelaySeconds = 1;
    float elapsedSeconds = 0;
	
	// Update is called once per frame
	void Update () {

        elapsedSeconds += Time.deltaTime;
        if (elapsedSeconds > ChangeDelaySeconds) {
            elapsedSeconds = 0;

            // destroy current moving sprite
            GameObject currentMovingSprite = GameObject.FindGameObjectWithTag("Moving Sprite");
            if (currentMovingSprite != null) {
                Destroy(currentMovingSprite);
            }

            // STUDENTS: uncomment the code below and make it generate a random number 
            // between 0 and 2 inclusive using the UnityEngine Random class and 
            // appropriate type casting
            int prefabNumber = Random.Range(0,2);

            // STUDENTS: uncomment the lines below and implement
            // the required code
            if (prefabNumber == 0) {

                Instantiate(prefabMovingSprite0);
                //    // STUDENTS: instantiate a new instance of the prefab
                //    // for MovingSprite0 at location(0, 0, 0)

                } else if (prefabNumber == 1) {

                //    // STUDENTS: instantiate a new instance of the prefab
                //    // for MovingSprite1 at location(0, 0, 0)

                Instantiate(prefabMovingSprite1);

                } else if (prefabNumber == 2) {

                //    // STUDENTS: instantiate a new instance of the prefab
                //    // for MovingSprite1 at location(0, 0, 0)

                Instantiate(prefabMovingSprite2);

                }
            }
    }

}

