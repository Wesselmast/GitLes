using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundscript : MonoBehaviour {


    void Update()
    {
        AudioSource myAudio = GetComponent<AudioSource>();
        int theChance = Random.Range(1, 100);
        if (theChance >= 0 && theChance <= 10 && !myAudio.isPlaying)
        {
            myAudio.PlayOneShot(myAudio.clip);
        }

    }
}
