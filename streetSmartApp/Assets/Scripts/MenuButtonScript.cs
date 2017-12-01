//Written by John Hainge
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    /// <summary>
    /// loads the edit vehicle info scene, this method is called when that corresponding button is pressed 
    /// </summary>
    public void LoadEditVehicleInfo()
	{
		SceneManager.LoadScene("EditVehicleInfo", LoadSceneMode.Single);
	}

    /// <summary>
    /// loads the links scene, this method is called when that corresponding button is pressed
    /// </summary>
    public void LoadLinks()
    {
        SceneManager.LoadScene("links", LoadSceneMode.Single);
    }

    /// <summary>
    /// loads the login scene, this method is called when that corresponding button is pressed
    /// </summary>
    public void LoadLogin()
    {
        SceneManager.LoadScene("login", LoadSceneMode.Single);
    }

    /// <summary>
    /// loads the splash screen scene, this is the scene when the app opens, so having a method call to it is a bit redendant
    /// </summary>
    public void LoadSplashScreen()
    {
        SceneManager.LoadScene("splashScreen", LoadSceneMode.Single);
    }

    /// <summary>
    /// loads the vehicle info scene, this method is called when that corresponding button is pressed
    /// </summary>
    public void LoadVehicleInfo()
    {
        SceneManager.LoadScene("VehicleInfo", LoadSceneMode.Single);
    }

    /// <summary>
    /// quits the app when the corresponding button is pressed 
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}