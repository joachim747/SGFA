﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAnimWaves : MonoBehaviour {

	public float power = 3;
	public float scale = 1;
	public float timescale = 1;

	private float xOffset;
	private float yOffset;
	private MeshFilter mf;

	// Use this for initialization
	void Start () {
		mf = GetComponent<MeshFilter>();
		MakeNoise();
	}
	
	// Update is called once per frame
	void Update () {
		MakeNoise();
		xOffset += Time.deltaTime * timescale;
		yOffset += Time.deltaTime * timescale;
	}

	void MakeNoise(){
		Vector3[] vertices = mf.mesh.vertices;

		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].y = CalculateHeight(vertices[i].x, vertices[i].z) * power;
		}
	}

	float CalculateHeight(float x, float y){
		float xCord = x * scale * xOffset;
		float yCord = y * scale * yOffset;

		return Mathf.PerlinNoise(xCord, yCord);
	}
}
