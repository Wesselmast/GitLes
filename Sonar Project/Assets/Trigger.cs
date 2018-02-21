using UnityEngine;
using System.Collections;

public class Trigger: MonoBehaviour
{
    private AudioSource aSource;
    public AudioClip Fantasy;

    void Awake()
    {
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {
            aSource.clip = Fantasy;
            aSource.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            aSource.clip = Fantasy;
            aSource.Pause();
        }
    }
}