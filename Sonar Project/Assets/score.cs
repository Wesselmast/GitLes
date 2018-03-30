using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

    float theScore = 0f;
	
	// Update is called once per frame
	void Update () {
        string thisScene = SceneManager.GetActiveScene().name;
        DontDestroyOnLoad(gameObject);

        if (thisScene == "Game")
        {
            theScore += Time.deltaTime;
        }

        if (thisScene == "Death")
        {
            Text scoreT = GameObject.Find("textscore").GetComponent<Text>();
            scoreT.text = "You survived for about " + Mathf.Round(theScore) + " seconds";
        }
	}
}
