using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echolocation : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        ParticleSystem echoBounce = GetComponent<ParticleSystem>();
        var coll = echoBounce.collision;
        coll.enabled = true;
        coll.bounce = 0.5f;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
