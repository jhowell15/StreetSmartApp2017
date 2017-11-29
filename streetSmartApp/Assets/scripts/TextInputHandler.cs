//Written by William Forrest
//With Code from Jacob Howell
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Xml;


public class TextInputHandler : MonoBehaviour
{

    //set up the different strings that will be set 
    public InputField userNameInput;
    public InputField addressInput;
    public InputField totalMilesInput;
    public InputField avgMilesInput;
    public InputField emailInput;
    public Dropdown vehicleTypeInput;

    /// <summary>
    /// write all the data to a file
    /// </summary>
    public void logIn()
    {
        //string userName = userNameInput.text;


        //write to the file 
        string filePath = Application.persistentDataPath + "/logInInfo.txt";
        StreamWriter file = new StreamWriter(filePath);
        int vehicleTypeInt = vehicleTypeInput.value;
		file.WriteLine(userNameInput.text + ";" + emailInput.text + ";" + addressInput.text + ";" + totalMilesInput.text + ";" + avgMilesInput.text + ";" + vehicleTypeInput.options[vehicleTypeInt].text.ToString() + ";" + System.DateTime.UtcNow);
        file.Close();
        Debug.Log("wrote file");
    }

}

