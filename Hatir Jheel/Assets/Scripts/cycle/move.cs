﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    
    public 
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	

     void Update()
     {
        
    
	
	}
     void OnTriggerEnter(Collider other)
     {
         Destroy(other.gameObject);
     }
}
