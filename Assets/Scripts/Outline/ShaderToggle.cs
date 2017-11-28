using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderToggle : MonoBehaviour {

	public Material defaultMaterial;
	public Material outlineMaterial;
	public Renderer objectRenderer;

	// Use this for initialization
	void Start () {	
	
		objectRenderer.material = defaultMaterial;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.S)) {
			objectRenderer.material = outlineMaterial;
		}		
			
	}
}
