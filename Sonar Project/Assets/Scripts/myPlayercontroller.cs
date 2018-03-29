using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayercontroller : MonoBehaviour {

    public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 forwardMovement = transform.position = transform.position + transform.forward * Time.deltaTime * moveSpeed * verticalAxis;
        Vector3 sidewardMovement = transform.position = transform.position + transform.right * Time.deltaTime * moveSpeed * horizontalAxis;

	}
}
