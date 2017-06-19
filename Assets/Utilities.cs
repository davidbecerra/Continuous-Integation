using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public int square(int x) {
        return x * x;
    }

    public int factorial(int x) {
        if (x <= 0) return x;
        return x * factorial(x - 1);
    }
}
