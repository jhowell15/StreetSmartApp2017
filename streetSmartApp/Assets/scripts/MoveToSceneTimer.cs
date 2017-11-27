using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MoveToSceneTimer : MonoBehaviour
{
    [SerializeField] private float time;
    private string login = "login";
    private string home = "vehicleInfo";
	
	// Update is called once per frame
	void Update ()
    {
        time -= Time.deltaTime;

        if(time <= 0.0f)
        {
            timerEnded();
        }
	}

    private void timerEnded()
    {
        try
        {
            StreamReader loginReader = new StreamReader(Application.persistentDataPath + "/loginInfo.txt");
            Debug.Log("file found");
            SceneManager.LoadScene(home, LoadSceneMode.Single);
        }
        catch
        {
            SceneManager.LoadScene(login, LoadSceneMode.Single);
        }
    }
}