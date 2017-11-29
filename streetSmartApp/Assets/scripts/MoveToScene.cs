//Written by Jacob Howell
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{
    //loads the target scene and unloads current scene
    public void OnMouseClick(string targetScene)
    {
        SceneManager.LoadScene(targetScene, LoadSceneMode.Single);
    }
}