using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stiff : MonoBehaviour {
    public GameObject myGameObject;
    private Mesh myMesh;
    private Cloth myCloth;
    private Bounds myBounds;
    private Vector3 min;
    private Vector3 max;
	// Use this for initialization
	void Start () {
        myMesh = myGameObject.GetComponent<MeshFilter>().mesh;
        myCloth = myGameObject.GetComponent<Cloth>();
        myBounds = myMesh.bounds;
        min = myBounds.min;
        max = myBounds.max;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
