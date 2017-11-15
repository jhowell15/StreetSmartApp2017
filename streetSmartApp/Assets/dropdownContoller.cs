using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEditor;
using UnityEngine.UI;

public class dropdownContoller : MonoBehaviour {
    public Dropdown dropdown;

	// Use this for initialization
	void Start () {
        XmlDocument doc = new XmlDocument();
        doc.Load("C:\\Users\\Jacob Howell\\Documents\\GitHub\\StreetSmartApp2017\\streetSmartApp\\vehicleMaintenanceSchedules.xml");
        Debug.Log("loaded maintenance");

        XmlNodeList nodeList = doc.SelectNodes("Generic_Vehicles/Vehicle_Type");
        List<string> stringList = new List<string>();
        foreach (XmlNode node in nodeList)
        {
            stringList.Add(node.Attributes.GetNamedItem("type").Value);
        }
        dropdown.AddOptions(stringList);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
