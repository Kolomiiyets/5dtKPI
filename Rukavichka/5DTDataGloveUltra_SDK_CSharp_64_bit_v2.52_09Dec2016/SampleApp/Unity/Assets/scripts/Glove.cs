using UnityEngine;
using System;
using System.Collections;
using FDTGloveUltraCSharpWrapper;

public class Glove : MonoBehaviour 
{
	
	CfdGlove guanteObject;
	
	// Use this for initialization
	void Start () {
	
		guanteObject = new CfdGlove();
		try{
			guanteObject.Open("USB0");
			light.intensity = 5.0f;
		} catch {
			light.intensity = 1.0f;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(guanteObject.IsOpen())
		{
			int gesture = guanteObject.GetGesture();
			light.color = Color.green;
			if (gesture.Equals(0))
			{
				light.color = Color.red;
			} else if (gesture.Equals(1)) {
				light.color = Color.yellow;
			}
		} else {
			if (Input.GetKey("1"))
			{
				light.color = Color.green;
			} else if (Input.GetKey("2")) {
				light.color = Color.yellow;
			} else if (Input.GetKey("3")) {
				light.color = Color.red;
			} else if (Input.GetKey("0")) {
				light.color = Color.white;
			}
		}
	
	}
	
	void OnGUI () 
	{
		string s;
		int offset = 20;
		for (int i = 0; i < 16; i++)
		{
			s = "Sensor " + i.ToString() + " scaled value = " + guanteObject.GetSensorScaled(i).ToString();
			GUI.Label(new Rect(10,offset,400,20+offset), s);
			offset += 20;
		}
		

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
//		if(GUI.Button(new Rect(20,40,80,20), "Level 1")) {
//			Application.LoadLevel(1);
//		}
//
//		// Make the second button.
//		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
//			Application.LoadLevel(2);
//		}
	}
}
