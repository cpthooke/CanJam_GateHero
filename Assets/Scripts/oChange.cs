﻿using UnityEngine;
using System.Collections;

public class oChange : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetAxis("FireO") == 1)) {// && (Input.GetAxis ("Jump") < 0 || Input.GetAxis ("Jump") > 0)) {

			spriteRenderer.sprite = sprite2;


		}
		else
			spriteRenderer.sprite = sprite1;
		Debug.Log (Input.GetAxis("FireO").ToString ());

	}
}