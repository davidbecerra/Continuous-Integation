﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = 10;
	}

	// Update is called once per frame
	void Update () {
        health += 1;
	}
}
