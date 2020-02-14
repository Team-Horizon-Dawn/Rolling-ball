using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private GameObject level;
	
	void Start () {
		rb = GetComponent<Rigidbody>();
		level = GameObject.Find("level");
	}

	void OnTriggerEnter(Collider other) {
	   if(other.gameObject.CompareTag("Pick Up")) {
		   switch (ColorUtility.ToHtmlStringRGB(other.gameObject.GetComponent<Renderer>().material.color))
		   {
			   case "0000FF":
				   level.GetComponent<GroundRotator>().speed *= 0.5f;
				   break;
			   case "00FF00":
				   Vector3 force = Vector3.up * 10;
				   GetComponent<Transform>().position += force;
				   break;
			   case "FF0000":
				   level.GetComponent<GroundRotator>().speed *= 1.5f;
				   break;
		   }
		   other.gameObject.SetActive(false);
		   
	   }
   }
}