using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

    public Button myButton;

	// Use this for initialization
	void Start () {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void TaskOnClick()
    {
        int theScene = SceneManager.GetActiveScene().buildIndex;
        
        if (SceneManager.GetActiveScene().name == "Death")
        {
            SceneManager.LoadScene(0);
        }
        else if (theScene < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(theScene + 1);
        }
            
    }
}
