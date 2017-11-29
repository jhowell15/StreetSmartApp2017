//Written by John Hainge
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
	public void LoadEditVehicleInfo()
	{
		SceneManager.LoadScene("EditVehicleInfo", LoadSceneMode.Single);
	}

    public void LoadLinks()
    {
        SceneManager.LoadScene("links", LoadSceneMode.Single);
    }

    public void LoadLogin()
    {
        SceneManager.LoadScene("login", LoadSceneMode.Single);
    }

    public void LoadSplashScreen()
    {
        SceneManager.LoadScene("splashScreen", LoadSceneMode.Single);
    }

    public void LoadVehicleInfo()
    {
        SceneManager.LoadScene("VehicleInfo", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}