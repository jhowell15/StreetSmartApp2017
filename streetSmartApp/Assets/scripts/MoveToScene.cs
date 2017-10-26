using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour {

    //THIS NEEDS TO BE CHANGED TO ON TAP OR WHATEVER THE MOBILE VERSION OF A CLICK IS
	public void OnMouseClick(string targetScene)
    {
        SceneManager.LoadScene(targetScene, LoadSceneMode.Single);
    }
}
