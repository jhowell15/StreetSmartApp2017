//Written by John Hainge
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    /// <summary>
    /// load the editvehicle info
    /// </summary>
	public void LoadEditVehicleInfo()
	{
		SceneManager.LoadScene("EditVehicleInfo", LoadSceneMode.Single);
	}


    /// <summary>
    /// load the links page 
    /// </summary>
    public void LoadLinks()
    {
        SceneManager.LoadScene("links", LoadSceneMode.Single);
    }

    /// <summary>
    /// load the login page 
    /// </summary>
    public void LoadLogin()
    {
        SceneManager.LoadScene("login", LoadSceneMode.Single);
    }

    /// <summary>
    /// load splash screen 
    /// </summary>
    public void LoadSplashScreen()
    {
        SceneManager.LoadScene("splashScreen", LoadSceneMode.Single);
    }

    public void LoadVehicleInfo()
    {
        SceneManager.LoadScene("VehicleInfo", LoadSceneMode.Single);
    }


    /// <summary>
    /// quit the app 
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}