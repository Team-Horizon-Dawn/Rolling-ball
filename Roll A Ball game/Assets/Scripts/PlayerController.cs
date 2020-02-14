using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
   
   void FixedUpdate () {
	   float moveHorizontal = Input.GetAxis("Horizontal");
	   float moveVertical = Input.GetAxis("Vertical");
	   
	   Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);
	   
	   rb.AddForce(movement * speed);
   }
   
   void OnTriggerEnter(Collider other) {
	   if(other.gameObject.CompareTag("Pick Up")) {
		   other.gameObject.SetActive(false);
		   switch (ColorUtility.ToHtmlStringRGB(other.gameObject.GetComponent<Renderer>().material.color))
		   {
			   case "0000FF":
				   speed *= 0.5f;
				   break;
			   case "00FF00":
				   Vector3 force = Vector3.up * 10;
				   GetComponent<Transform>().position += force;
				   break;
			   case "FF0000":
				   speed *= 1.5f;
				   break;
		   }
	   }
   }
}