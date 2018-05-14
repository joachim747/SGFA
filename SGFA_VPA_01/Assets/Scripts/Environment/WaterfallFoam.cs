using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallFoam : MonoBehaviour {

	public float power = 3;
	public float scale = 1;
	public float timescale = 1;

	private float xOffset;
	private float yOffset;
	private MeshFilter[] mfs;
	private Mesh[] originalMeshes;

	// Use this for initialization
	void Start () {
		mfs = new MeshFilter[this.transform.childCount];
		originalMeshes = new Mesh[this.transform.childCount];
		for (int i = 0; i < this.transform.childCount; i++){
			mfs[i] = this.transform.GetChild(i).GetComponent<MeshFilter>();
			originalMeshes[i] = mfs[i].mesh;
		}

		MakeNoise();
	}
	
	// Update is called once per frame
	void Update () {
		MakeNoise();
		xOffset += Time.deltaTime * timescale;
		yOffset += Time.deltaTime * timescale;
	}

	void MakeNoise(){
		for (int i = 0; i < this.transform.childCount; i++){
			Vector3[] vertices = mfs[i].mesh.vertices;

			for (int j = 0; j < vertices.Length; j++)
			{
					vertices[j].z = /*originalMeshes[i].vertices[j].z +*/ CalculateHeight(vertices[j].x, vertices[j].y) * power;
					//vertices[j].y = originalMeshes[i].vertices[j].z + CalculateHeight(vertices[j].x, vertices[j].z) * power;
					//vertices[j].x = originalMeshes[i].vertices[j].z + CalculateHeight(vertices[j].y, vertices[j].z) * power;			
			}
	    	mfs[i].mesh.vertices = vertices;
		}
	}

	float CalculateHeight(float x, float y){
		float xCord = x * scale * xOffset;
		float yCord = y * scale * yOffset;
		return Mathf.PerlinNoise(xCord, yCord);
	}
}
