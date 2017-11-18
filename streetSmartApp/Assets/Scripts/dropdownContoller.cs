using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
//using UnityEditor;
using UnityEngine.UI;

public class dropdownContoller : MonoBehaviour
{
    public Dropdown dropdown;

    // Use this for initialization
    void Start()
    {
        XmlDocument doc = new XmlDocument();
        string filepath = Application.persistentDataPath + "vehicleMaintenanceSchedules_GENERIC.xml";
        doc.Load(filepath);
        Debug.Log("loaded generic maintenance");

        XmlNodeList nodeList = doc.SelectNodes("/Generic_Vehicles/Vehicle_Type");
        List<string> stringList = new List<string>();
        foreach (XmlNode node in nodeList)
        {
            stringList.Add(node.Attributes.GetNamedItem("type").Value);
        }
        dropdown.AddOptions(stringList);
        filepath = "";

        filepath = Application.persistentDataPath + "/vehicleMaintenanceSchedules_SPECIFIC.xml";
        doc.Load(filepath);
        Debug.Log("loaded specific maintenance");

        nodeList = doc.SelectNodes("/Specific_Vehicles/Vehicle");
        stringList = new List<string>();
        foreach (XmlNode node in nodeList)
        {
            stringList.Add(node.Attributes.GetNamedItem("name").Value);
        }
        dropdown.AddOptions(stringList);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
