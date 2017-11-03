using UnityEngine;
using System.Collections;

public class MouseVisibleScript : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
    void Update ()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}