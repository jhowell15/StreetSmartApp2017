using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserDataSheet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        
            StreamReader input = null;
        //chech to see if the user has already loged in 
        try
        {
            input = File.OpenText("logInInfo.txt");
            input.Close();
        }
        catch
        {   
            //create the data file if it dose not already exist 
            //StreamWriter logeInInfo = File.CreateText("logInInfo.txt");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
