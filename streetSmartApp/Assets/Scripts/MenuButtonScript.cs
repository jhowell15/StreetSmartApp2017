using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
	public void LoadEditVehicleInfo()
	{
		SceneManager.LoadScene("EditVehicleInfo");
	}

    public void LoadLinks()
    {
        SceneManager.LoadScene("Links");
    }

    public void LoadLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void LoadSplashScreen()
    {
        SceneManager.LoadScene("SplashScreen");
    }

    public void LoadVehicleInfo()
    {
        SceneManager.LoadScene("VehicleInfo");
    }

    public void Quit()
    {
        Application.Quit();
    }
}