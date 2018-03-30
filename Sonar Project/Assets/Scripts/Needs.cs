    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Needs : MonoBehaviour {

    public float foodLevel = 100;
    public float waterLevel = 100;
    public float refillWaterSpeed = 1f;
    public float refillFoodSpeed = 25f; 

    // Update is called once per frame
    void Update () {
        foodLevel -= Time.smoothDeltaTime;
        waterLevel -= Time.smoothDeltaTime;
 //       Debug.Log(foodLevel + "and" + waterLevel);

        if (foodLevel <= 0 || waterLevel <= 0)
        {
            //rip player
            int theScene = SceneManager.GetActiveScene().buildIndex;
            if (theScene < SceneManager.sceneCountInBuildSettings)
                SceneManager.LoadScene(theScene + 1); 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "waterWalls")
        {
            waterLevel += refillWaterSpeed;
        }

        if (collision.gameObject.tag == "monsterSnack")
        {
            foodLevel += refillFoodSpeed;
            Destroy(collision.gameObject);
        }
    }
}
