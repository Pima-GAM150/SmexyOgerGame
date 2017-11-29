using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderToggle : MonoBehaviour {

	public Material defaultMaterial;
	public Material enemyOutline;
	public Material interactableOutline;
	public Renderer[] enemyRenderers;
	public Renderer[] interactableRenderers;

	// Use this for initialization
	void Start () {	
		}
	
	// Update is called once per frame
	void Update () {

		foreach (Renderer enemy in enemyRenderers) {
			if (Vector3.Distance (enemy.transform.position, gameObject.transform.position) < 5) {
				enemy.material = enemyOutline;
				//give permission to controller to pick up human
			}
			else
				enemy.material = defaultMaterial;
		}
		foreach (Renderer interactable in interactableRenderers) {
			if (Vector3.Distance (interactable.transform.position, gameObject.transform.position) < 5) {
				interactable.material = interactableOutline;
				//give permission to controller to pick up human
			}
			else
				interactable.material = defaultMaterial;
		}

	
			
	}
}
