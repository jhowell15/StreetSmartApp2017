using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToSceneTimer : MonoBehaviour {

    [SerializeField] private float time;
    [SerializeField] private string targetScene;
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if(time <= 0.0f)
        {
            timerEnded(targetScene)
        }


	}

    private void timerEnded(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}
