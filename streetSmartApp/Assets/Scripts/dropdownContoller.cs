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
        string fileName = "";
        string file = "";

        WWW www;

        XmlDocument doc;

        file = "vehicleMaintenanceSchedules_GENERIC.xml";
        fileName = Application.streamingAssetsPath + "/" + file;

        //www = new WWW(fileName);
        //yield return www;

        doc = new XmlDocument();

        try
        {
            Debug.Log("file path: " + fileName);
            //Debug.Log("www file path: " + www.text);
            doc.Load(fileName);
            Debug.Log("loaded generic maintenance");

            XmlNodeList nodeList = doc.SelectNodes("/Generic_Vehicles/Vehicle_Type");
            List<string> stringList = new List<string>();
            foreach (XmlNode node in nodeList)
            {
                stringList.Add(node.Attributes.GetNamedItem("type").Value);
            }
            dropdown.AddOptions(stringList);
        }
        catch
        {
            Debug.Log("failed generic");
        }



        file = "vehicleMaintenanceSchedules_Specific.xml";
        fileName = Application.streamingAssetsPath + "/" + file;

        www = new WWW(fileName);
        //yield return www;

        doc = new XmlDocument();

        try
        {
            doc.LoadXml(fileName);
            Debug.Log("loaded specific maintenance");

            XmlNodeList nodeList = doc.SelectNodes("/Specific_Vehicles/Vehicle");
            List<string> stringList = new List<string>();
            foreach (XmlNode node in nodeList)
            {
                stringList.Add(node.Attributes.GetNamedItem("name").Value);
            }
            dropdown.AddOptions(stringList);
        }
        catch
        {
            Debug.Log("failed specific");
        }


        //StartCoroutine(Init());
    }

    // Update is called once per frame
    //public IEnumerator Init()
    //{
    //    string fileName = "";
    //    string file = "";

    //    WWW www;

    //    XmlDocument doc;

    //    file = "vehicleMaintenanceSchedules_GENERIC.xml";
    //    fileName = Application.streamingAssetsPath + "/" + file;

    //    www = new WWW(fileName);
    //    //yield return www;

    //    doc = new XmlDocument();

    //    try
    //    {
    //        doc.Load(www.text);
    //        Debug.Log("loaded generic maintenance");

    //        XmlNodeList nodeList = doc.SelectNodes("/Generic_Vehicles/Vehicle_Type");
    //        List<string> stringList = new List<string>();
    //        foreach (XmlNode node in nodeList)
    //        {
    //            stringList.Add(node.Attributes.GetNamedItem("type").Value);
    //        }
    //        dropdown.AddOptions(stringList);
    //    }
    //    catch
    //    {
    //        Debug.Log("failed generic");
    //    }

        

    //    file = "vehicleMaintenanceSchedules_Specific.xml";
    //    fileName = Application.streamingAssetsPath + "/" + file;

    //    www = new WWW(fileName);
    //    //yield return www;

    //    doc = new XmlDocument();

    //    try
    //    {
    //        doc.LoadXml(www.text);
    //        Debug.Log("loaded specific maintenance");

    //        XmlNodeList nodeList = doc.SelectNodes("/Specific_Vehicles/Vehicle");
    //        List<string> stringList = new List<string>();
    //        foreach (XmlNode node in nodeList)
    //        {
    //            stringList.Add(node.Attributes.GetNamedItem("name").Value);
    //        }
    //        dropdown.AddOptions(stringList);
    //    }
    //    catch
    //    {
    //        Debug.Log("failed specific");
    //    }

    //}
}
