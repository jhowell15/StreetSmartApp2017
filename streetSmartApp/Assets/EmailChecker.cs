//Written Jacob Howell
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailChecker : MonoBehaviour
{

    public InputField emailField;

    //Checks if the user entered a valid email address
    public void EmailCheck()
    {
        string input = emailField.text.ToString();

        if (!input.Contains("@"))
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
}