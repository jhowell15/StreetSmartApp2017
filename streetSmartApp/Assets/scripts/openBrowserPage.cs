//Written by Jacob Howell
//For The University of Colorado, Colorado Springs & StreetSmart Auto Brokers
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBrowserPage : MonoBehaviour
{
    [SerializeField] string targetURL;

    //opens a browser page based on the target URL that is passed in
	public void OnMouseClick(string targetURL)
    {
        Application.OpenURL(targetURL);
    }
}