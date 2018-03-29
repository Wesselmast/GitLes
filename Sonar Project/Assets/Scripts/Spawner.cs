using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnWait = 2f;
    public GameObject monsterSnack;

    // Update is called once per frame
    void FixedUpdate () {

        monsterSnack.transform.position = transform.position;
        spawnWait -= Time.deltaTime;
        if (spawnWait <= 0f)
        {
            Instantiate(monsterSnack);
            spawnWait = 2f;
        }
    }   


}
