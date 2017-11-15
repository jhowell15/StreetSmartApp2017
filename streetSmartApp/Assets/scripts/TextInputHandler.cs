using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Xml;


public class TextInputHandler : MonoBehaviour {

    //set up the different strings that will be set 
    public InputField userNameInput;
    public InputField addressInput;
    public InputField totalMilesInput;
    public InputField avgMilesInput;
    public InputField emailInput;
	
    /// <summary>
    /// write all the data to a file
    /// </summary>
public void logIn()
    {
        //string userName = userNameInput.text;
        

        //write to the file 
        StreamWriter file = new StreamWriter("logInInfo.txt");
        file.WriteLine(userNameInput.text +";"+emailInput.text + ";" +addressInput.text + ";" +totalMilesInput.text + ";" +avgMilesInput.text);
        file.Close();
    }

    public void populateDropDown(Dropdown dropdown)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("vehicleMaintenanceSchedules");
        Debug.Log("loaded maintenance");

        XmlNodeList nodeList = doc.SelectNodes("Generic_Vehicles/Vehicle_Type");
        List<string> stringList = new List<string>();
        foreach(XmlNode node in nodeList)
        {
            stringList.Add(node.Attributes.GetNamedItem("type").Value);
        }
        dropdown.AddOptions(stringList);

    }

}

