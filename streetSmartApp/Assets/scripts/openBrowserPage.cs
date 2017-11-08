using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBrowserPage : MonoBehaviour
{
    [SerializeField] string targetURL;

	public void OnMouseClick(string targetURL)
    {
        Application.OpenURL(targetURL);
    }
}