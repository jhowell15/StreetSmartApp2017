//Written by Ryan Rabinowitz
//With Code from Jacob Howell, William Forrest
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Xml;
using UnityEngine.SceneManagement;

public class EditVehicleScript : MonoBehaviour
{

	//set up the different strings that will be set 
	public InputField totalMilesInput;
	public InputField avgMilesInput;
	public Dropdown vehicleTypeInput;


	/// <summary>
	/// write all the data to a file
	/// </summary>
	public void writeData()
	{
		//string userName = userNameInput.text;

		string filePath = Application.persistentDataPath + "/logInInfo.txt";
		StreamReader oldFile = new StreamReader (filePath);
		string data = oldFile.ReadLine();
		string[] fields = data.Split (';');
		oldFile.Close ();
		//write to the file 
		filePath = Application.persistentDataPath + "/logInInfo.txt";
		StreamWriter file = new StreamWriter(filePath);
		int vehicleTypeInt = vehicleTypeInput.value;
		file.WriteLine(fields[0] + ";" + fields[1] + ";" + fields[2] + ";" + totalMilesInput.text + ";" + avgMilesInput.text + ";" + vehicleTypeInput.options[vehicleTypeInt].text.ToString() + ";" + System.DateTime.UtcNow);
		file.Close();
		Debug.Log("wrote file");
		SceneManager.LoadScene("VehicleInfo", LoadSceneMode.Single);
	}

}

