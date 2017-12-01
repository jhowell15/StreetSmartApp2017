//Written by Jacob Howell
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
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
            //EmailReminder();
        }
	}

    //Sends an email to the user reminding them of the next maintenance
    //not currently used
    private void EmailReminder()
    {
        string emailAddress;
        StreamReader reader = new StreamReader(Application.persistentDataPath + "/loginInfo.txt");

        emailAddress = reader.ReadLine();

        int emailAddressStartLoc = emailAddress.IndexOf(";") + 1;
        Debug.Log("email address pre edit: " + emailAddress);
        emailAddress = emailAddress.Substring(emailAddressStartLoc, emailAddress.IndexOf(";", emailAddressStartLoc));
        emailAddress = emailAddress.Substring(0, emailAddress.IndexOf(";"));

        Debug.Log("email address post edit: " + emailAddress);

        string emailSubject = MyEscapeURL("StreetSmart App Email Test");
        string emailBody = MyEscapeURL("test test test");

        Debug.Log("mailto:" + emailAddress + "?subject=" + emailSubject + "&body=" + emailBody);

        string email = "mailto:" + emailAddress + "?subject=" + emailSubject + "&body=" + emailBody;
        Debug.Log(email);

        Application.OpenURL(email);

    }

    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }

    //moves to the next scene when the timer ends
    private void timerEnded()
    {
        try
        {
            StreamReader loginReader = new StreamReader(Application.persistentDataPath + "/loginInfo.txt");
            Debug.Log("file found");
            loginReader.Close();
            //EmailReminder();
            SceneManager.LoadScene(home, LoadSceneMode.Single);

        }
        catch
        {
            SceneManager.LoadScene(login, LoadSceneMode.Single);
        }
    }
}