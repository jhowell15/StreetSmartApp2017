using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBrowserPage : MonoBehaviour
{
	public void OnMouseClick(string targetURL)
    {
        Application.OpenURL(targetURL);
    }
}