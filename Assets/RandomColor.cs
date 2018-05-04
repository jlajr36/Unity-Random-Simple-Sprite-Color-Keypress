using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {
	
	public Color[] ColorBank;

	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			int num = Random.Range(0, ColorBank.Length);
			SpriteRenderer sr = GetComponent<SpriteRenderer>();
			sr.color = ColorBank[num];
		}
	}
}
