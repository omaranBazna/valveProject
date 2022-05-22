using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour {
    public GameObject meshO;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<MeshFilter>().mesh = meshO.GetComponent<MeshFilter>().mesh;
	}
}
