﻿using UnityEngine;
using System.Collections;

public class CloudsManager : MonoBehaviour {

	void Start ()
    {
	
	}

    void Move()
    {
        if(this.name.Equals("Nuvens"))
        {
            this.transform.Translate(-1 * 0.1f * Time.deltaTime, 0, 0);
        }

        if (this.name.Equals("Nuvens3") || this.name.Equals("Nuvens3"))
        {
            this.transform.Translate(-1 * 0.05f * Time.deltaTime, 0, 0);
        }

        if (this.name.Equals("CloudsCanvas"))
        {
            this.GetComponent<RectTransform>().transform.Translate();
        }
    }
	

	void FixedUpdate () 
    {
        Move();
	}
}
