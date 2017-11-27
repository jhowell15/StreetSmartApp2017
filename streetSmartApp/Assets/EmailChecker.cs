using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailChecker : MonoBehaviour {

    public InputField emailField;

	// Use this for initialization
	public void EmailCheck () {
        string input = emailField.text.ToString();

        if(!input.Contains("@"))
        {
            Debug.Log("not valid email");
            emailField.text = "INVALID EMAIL ADDRESS";
            //emailField.textComponent.text = "That is not a valid email address.";
        }
        else
        {
            Debug.Log("valid email");   
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
