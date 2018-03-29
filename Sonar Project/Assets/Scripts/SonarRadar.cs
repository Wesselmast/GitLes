using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarRadar : MonoBehaviour
{

    public GameObject echo;
    public float coolDownTime = 3f;
    float coolDownPeriod = 0f;

    void FixedUpdate()
    {

        coolDownPeriod -= Time.smoothDeltaTime;

        if (coolDownPeriod <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                echo.transform.position = transform.position;
                Instantiate(echo);
                coolDownPeriod = coolDownTime;
            }
        }
    }


}


