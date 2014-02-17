using UnityEngine;
using System.Collections;

public class ColorOnStart : MonoBehaviour {
	
	public Color myColor;
	
	void Start () {
		this.renderer.material.color = myColor;
	}
}
