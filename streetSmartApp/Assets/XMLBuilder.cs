using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class XMLBuilder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        XmlDocument doc = new XmlDocument();
        XmlNode root = doc.CreateElement("Generic_Vehicles");
        doc.AppendChild(root);

        XMLSUV(doc, root);
        XML4DOOR(doc, root);
        XML2DOOR(doc, root);
        XMLWAGON(doc, root);
        XMLSPORTS(doc, root);
        XMLMINIVAN(doc, root);
        XMLPICKUP(doc, root);

        doc.Save(Application.persistentDataPath + "/vehicleMaintenanceSchedules_GENERIC.xml");
        Debug.Log(Application.persistentDataPath + "/vehicleMaintenanceSchedules_GENERIC.xml");
        Debug.Log("finished generic");

        XmlDocument doc2 = new XmlDocument();
        XmlNode root2 = doc2.CreateElement("Specific_Vehicles");
        doc2.AppendChild(root2);

        XML4RUNNER(doc2, root2);
        XMLCAMRY(doc2, root2);
        XMLOUTBACK(doc2, root2);
        XMLF150(doc2, root2);
        XMLODESSEY(doc2, root2);

        doc2.Save(Application.persistentDataPath + "/vehicleMaintenanceSchedules_SPECIFIC.xml");
        Debug.Log(Application.persistentDataPath + "/vehicleMaintenanceSchedules_SPECIFIC.xml");
        Debug.Log("finished specific");
    }

    private void XMLSUV(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "SUV");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change and Tire Rotation";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Transmission Fluid, Differential Fluid, Engine Oil and Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Coolent, Differential Fluid, Oil Change, Transmission Fluid, Spark Plugs";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change, Retorque Driveshaft";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Oil Change, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Oil Change, Transmission Fluid, Coolent, Spark Plugs, Retorque Driveshaft";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Oil Change, Coolent, Spark Plugs, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XML4DOOR(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "4 Door Sedan");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Axle Fluid, Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Oil Change, Axle Fluid, Coolent, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Differential Fluid, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Coolent, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XML2DOOR(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "2 Door Coupe");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "87000");
        maintenance.InnerText = "Automatic Tranaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLWAGON(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "Station Wagon");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "3750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "7500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "11250");
        maintenance.InnerText = "Transmission Fluid, Differential Fluid, Engine Oil and Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Oil, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "18750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "22500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "26250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Oil, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "33750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "37500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "41250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "48750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "52500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "56250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "63750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "67500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "71250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "78750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "82500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "86250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "93750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "101250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLSPORTS(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "Sports Car");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Read Out Diagnostic System, Oil Change, Oil Filter, Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Read Out Diagnostic System, Oil Change, Oil Filter, Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Drive Belt, Air Filter, Oil Filter, Spark Plugs";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change, Air Filter, Air Cleaner Element";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        //maintenance.InnerText = "";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "120000");
        maintenance.InnerText = "Spark Plugs, Automatic Transaxle Fluid, Manual Transaxle Fluid, Drive Belt";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLMINIVAN(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "Mini Van");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter, Timing Belt";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter, Timing Belt";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLPICKUP(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle_Type");
        node.SetAttribute("type", "Pickup Truck");
        root.AppendChild(node);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter, U Joints";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter, Spark Plugs, Transfer Case Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner Element";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Engine Coolent, Rear Axle Fluid, Spark Plugs";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "120000");
        maintenance.InnerText = "Air Cleaner Element";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "150000");
        maintenance.InnerText = "Accessory Drive Belt, Air Cleaner Element, Automatic Transmission Filter, Engine Coolent, Front Axle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XML4RUNNER(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle");
        node.SetAttribute("name", "2005 Toytota 4 Runner");
        root.AppendChild(node);

        XmlElement makeNode = doc.CreateElement("Make");
        makeNode.InnerText = "Toyota";
        node.AppendChild(makeNode);

        XmlElement modelNode = doc.CreateElement("Model");
        modelNode.InnerText = "4 Runner";
        node.AppendChild(modelNode);

        XmlElement yearNode = doc.CreateElement("Year");
        yearNode.InnerText = "2005";
        node.AppendChild(yearNode);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change and Tire Rotation";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Transmission Fluid, Differential Fluid, Engine Oil and Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Coolent, Differential Fluid, Oil Change, Transmission Fluid, Spark Plugs";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change, Retorque Driveshaft";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Oil Change, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Oil Change, Transmission Fluid, Coolent, Spark Plugs, Retorque Driveshaft";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Oil Change, Coolent, Spark Plugs, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLCAMRY(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle");
        node.SetAttribute("name", "2005 Toyota Camry");
        root.AppendChild(node);

        XmlElement makeNode = doc.CreateElement("Make");
        makeNode.InnerText = "Toyota";
        node.AppendChild(makeNode);

        XmlElement modelNode = doc.CreateElement("Model");
        modelNode.InnerText = "Camry";
        node.AppendChild(modelNode);

        XmlElement yearNode = doc.CreateElement("Year");
        yearNode.InnerText = "2005";
        node.AppendChild(yearNode);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Axle Fluid, Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Oil Change, Axle Fluid, Coolent, Transmission Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Differential Fluid, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Coolent, Automatic Transaxle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLOUTBACK(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle");
        node.SetAttribute("name", "2005 Subaru Outback");
        root.AppendChild(node);

        XmlElement makeNode = doc.CreateElement("Make");
        makeNode.InnerText = "Subaru";
        node.AppendChild(makeNode);

        XmlElement modelNode = doc.CreateElement("Model");
        modelNode.InnerText = "Outback";
        node.AppendChild(modelNode);

        XmlElement yearNode = doc.CreateElement("Year");
        yearNode.InnerText = "2005";
        node.AppendChild(yearNode);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "3750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "7500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "11250");
        maintenance.InnerText = "Transmission Fluid, Differential Fluid, Engine Oil and Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Oil, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "18750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "22500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "26250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Oil, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "33750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "37500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "41250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "48750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "52500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "56250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "63750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "67500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "71250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Automatic Transaxle Fluid, Brake Fluid, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "78750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "82500");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "86250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner/Element, Automatic Transaxle Fluid, Brake Fluid, Coolent, Differential Fluid, Engine Oil, Engine Oil Filter, Manual Transaxle Fluid, Spark Plugs, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "93750");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "101250");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter, Rotate Tires";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLF150(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle");
        node.SetAttribute("name", "2005 Ford F150");
        root.AppendChild(node);

        XmlElement makeNode = doc.CreateElement("Make");
        makeNode.InnerText = "Ford";
        node.AppendChild(makeNode);

        XmlElement modelNode = doc.CreateElement("Model");
        modelNode.InnerText = "F150";
        node.AppendChild(modelNode);

        XmlElement yearNode = doc.CreateElement("Year");
        yearNode.InnerText = "2005";
        node.AppendChild(yearNode);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter, U Joints";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner Element, Engine Oil, Engine Oil Filter, Spark Plugs, Transfer Case Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner Element";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Engine Coolent, Rear Axle Fluid, Spark Plugs";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "120000");
        maintenance.InnerText = "Air Cleaner Element";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "150000");
        maintenance.InnerText = "Accessory Drive Belt, Air Cleaner Element, Automatic Transmission Filter, Engine Coolent, Front Axle Fluid";
        maintenanceScheduleNode.AppendChild(maintenance);
    }

    private void XMLODESSEY(XmlDocument doc, XmlNode root)
    {
        XmlElement node = doc.CreateElement("Vehicle");
        node.SetAttribute("name", "2005 Honda Odessey");
        root.AppendChild(node);

        XmlElement makeNode = doc.CreateElement("Make");
        makeNode.InnerText = "Honda";
        node.AppendChild(makeNode);

        XmlElement modelNode = doc.CreateElement("Model");
        modelNode.InnerText = "Odessey";
        node.AppendChild(modelNode);

        XmlElement yearNode = doc.CreateElement("Year");
        yearNode.InnerText = "2005";
        node.AppendChild(yearNode);

        XmlElement maintenanceScheduleNode = doc.CreateElement("Maintenance_Schedule");
        node.AppendChild(maintenanceScheduleNode);

        XmlElement maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "5000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "10000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "15000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "20000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "25000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "30000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "35000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "40000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "45000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "50000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "55000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "60000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter, Timing Belt";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "65000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "70000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "75000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "80000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "85000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "90000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "95000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "100000");
        maintenance.InnerText = "Oil Change";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter";
        maintenanceScheduleNode.AppendChild(maintenance);

        maintenance = doc.CreateElement("Maintenance");
        maintenance.SetAttribute("miles", "105000");
        maintenance.InnerText = "Air Cleaner Element, Cabin Air Filter, Timing Belt";
        maintenanceScheduleNode.AppendChild(maintenance);
    }
}
