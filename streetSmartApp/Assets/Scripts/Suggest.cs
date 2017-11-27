using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.UI;

public class Suggest : MonoBehaviour {
	public Text output;
	public Text output2;

	// Use this for initialization
	void Start () {
		string filePath = Application.persistentDataPath + "/logInInfo.txt";
		StreamReader file = new StreamReader (filePath);
		string data = file.ReadLine ();
		string[] fields = data.Split (';');
		string[] temp = fields [6].Split (' ');
		string[] date = temp[0].Split('/');
		Debug.Log (date[0]);
		System.DateTime old = new System.DateTime (int.Parse (date [2]), int.Parse (date [0]), int.Parse (date [1]), 0, 0, 0, System.DateTimeKind.Utc);
		int time = (int)(System.DateTime.UtcNow - old).TotalSeconds;
		time = time / 60 / 60 / 12 / 7;
		file.Close();

		XmlDocument doc = new XmlDocument();
		string filepath = Application.persistentDataPath + "/vehicleMaintenanceSchedules_GENERIC.xml";
		doc.Load(filepath);
		Debug.Log("loaded generic maintenance");

		XmlNodeList nodeList = doc.SelectNodes("/Generic_Vehicles/Vehicle_Type");
		List<string> stringList = new List<string>();
		List<string> stringList2 = new List<string>();
		int cnt = 0;
		foreach (XmlNode node in nodeList)
		{

			if (node.Attributes.GetNamedItem("type").Value == fields[5]) {

				XmlNodeList nodeList2 = node.SelectNodes ("Maintenance_Schedule/Maintenance");
				foreach (XmlNode node2 in nodeList2) {
					if ((int.Parse (node2.Attributes.GetNamedItem ("miles").Value) > (int.Parse (fields [4].ToString ()) * time) + int.Parse (fields [3].ToString ())) && cnt < 5) {
						cnt++;
						stringList.Add(node2.Attributes.GetNamedItem ("miles").Value);
						stringList2.Add(node2.InnerText);
					}
				}
			}
		}

        doc = new XmlDocument();
        filepath = Application.persistentDataPath + "/vehicleMaintenanceSchedules_SPECIFIC.xml";
        doc.Load(filepath);
        Debug.Log("loaded specific maintenance");

        nodeList = doc.SelectNodes("/Specific_Vehicles/Vehicle");
        stringList = new List<string>();
        stringList2 = new List<string>();
        cnt = 0;
        foreach (XmlNode node in nodeList)
        {

            if (node.Attributes.GetNamedItem("name").Value == fields[5])
            {

                XmlNodeList nodeList2 = node.SelectNodes("Maintenance_Schedule/Maintenance");
                foreach (XmlNode node2 in nodeList2)
                {
                    if ((int.Parse(node2.Attributes.GetNamedItem("miles").Value) > (int.Parse(fields[4].ToString()) * time) + int.Parse(fields[3].ToString())) && cnt < 5)
                    {
                        cnt++;
                        stringList.Add(node2.Attributes.GetNamedItem("miles").Value);
                        stringList2.Add(node2.InnerText);
                    }
                }
            }
        }

        string full = "";
		string full2 = "";

		for (int i = 0; i < cnt; i++) {
			full = full + stringList[i] + "\n";
			full2 = full2 + stringList2 [i] + "\n";
		}

		//output = GetComponent<MatInfo>();

		Debug.Log(full);
		output.text = full;
		output2.text = full2;

	}

	// Update is called once per frame
	void Update () {

	}
}
