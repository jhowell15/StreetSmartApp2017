using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class TextInputHandler : MonoBehaviour {

    //set up the different strings that will be set 
    string userName;
    float milesDriven;
    string userEmail;
    float milesPerWeek;
    string userAdress;
	
	
   /// <summary>
   /// get and save the user's name 
   /// </summary>
   /// <param name="username"></param>
   public void UserName(string username)
    {
        try
        {
          userName= username;
            Debug.Log("name");
            
        }
        catch {
            
        }

    } 

    /// <summary>
    /// .takes in and saves the miles driven
    /// </summary>
    /// <param name="milesDrivenString"></param>
public void MilesDriven(string milesDrivenString)
    {
       try
        {
            milesDriven = float.Parse(milesDrivenString);
        }
        catch
        {
            Debug.Log("enter a number ");
        }
    }
    public void MilesPerWeek(string miles)
    {
        try
        {
            milesPerWeek = float.Parse(miles);
        }
        catch { Debug.Log("enter a number");
        }
    }
    /// <summary>
    /// get and save user email 
    /// </summary>
    /// <param name="email"></param>
public void UserEmail(string email)
    {
        try
        {
            email = userEmail;
        }
        catch
        {

        }
    }
public void Adress(string address)
    {
        try
        {
            address = userAdress;
        }
        catch { }
    }
    /// <summary>
    /// write all the data to a file
    /// </summary>
public void logIn()
    {
        //write to the file 
        StreamWriter file = File.CreateText("C:\\Users\\William Forrest\\Documents\\GitHub\\StreetSmartApp2017\\streetSmartApp\\logInInfo.txt");
        file.WriteLine(userAdress+","+userEmail + "," +userName + "," +milesDriven + "," +milesPerWeek);
        file.Close();
    }

}

