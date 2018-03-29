using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour {

    public float moveSpeed = 3f;
    public float rotationSpeed = 100f;
    public float lifeSpan = 10f;

    bool timerRunning = true;
    bool isWandering = false;
    bool isWalking = false;
    bool isRotatingLeft = false;
    bool isRotatingRight = false;
    
	void FixedUpdate () {
        if (timerRunning)
        {
            lifeSpan -= Time.smoothDeltaTime;
            if (lifeSpan > 0)
            {
                if (isWandering == false)
                {
                    StartCoroutine(doWander());
                }

                if (isRotatingRight == true)
                {
                    transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
                }
                if (isRotatingLeft == true)
                {
                    transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
                }
                if (isWalking == true)
                {
                    transform.position += transform.forward * Time.deltaTime * moveSpeed;
                }
            }
            else
            {
                Destroy(gameObject);
                timerRunning = false;
            }

        }

	
    }

    IEnumerator doWander()
    {
        int rotationTime = Random.Range(1, 3);
        int rotationWait = Random.Range(1, 2);
        int leftOrRight = Random.Range(1, 2);
        int walkWait = Random.Range(1, 2);
        int walkTime = Random.Range(1, 3);

        isWandering = true;
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotationWait);
        if (leftOrRight == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }
        if (leftOrRight == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }
        isWandering = false;
    }
}
