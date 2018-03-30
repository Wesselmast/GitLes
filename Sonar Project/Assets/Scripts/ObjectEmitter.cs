using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEmitter : MonoBehaviour {

    public float floor = 0.0f;
    public float ceiling = 0.4f;
    public float oscillation = 1.0f;
    public GameObject triggersphere;
    public GameObject visual;
    public GameObject echo;
    public float scaleSpeed = 0.5f;
    public float theTime = 2f;
    public AudioClip echoStart;
    public AudioClip echoEnd;

    bool isScaling = false;

    public AudioSource echopulse;

    private void FixedUpdate()
    {
        Renderer renderer = visual.GetComponent<Renderer>();
        Material echoMat = renderer.material;

        float emission = floor + Mathf.PingPong(Time.time * oscillation, ceiling - floor);
        Color baseColor = Color.green;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        echoMat.SetColor("_EmissionColor", finalColor);
        if (!isScaling)
        {
            StartCoroutine(echoScale());
        }
    }

        IEnumerator echoScale()
    {
        echopulse.clip = echoStart;
        if (!echopulse.isPlaying)
            echopulse.Play();
        triggersphere.transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        visual.transform.localScale += new Vector3(scaleSpeed *50, scaleSpeed*50, scaleSpeed *50);
        yield return new WaitForSeconds(theTime);
        isScaling = true;
        StartCoroutine(echoShrink());
    }

    IEnumerator echoShrink()
    {
        echopulse.pitch = -1;
        if (!echopulse.isPlaying)
            echopulse.Play();
        triggersphere.transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
        visual.transform.localScale -= new Vector3(scaleSpeed * 50, scaleSpeed*50, scaleSpeed * 50);
        yield return new WaitForSeconds(theTime + 0.1f);
        Destroy(echo);
        isScaling = false;
    }



}
