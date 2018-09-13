using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject particlePlane;
    public Vector3[] intersection;
    public ParticleSystem particular;
    //public ParticleSystem[] particulars;
    public Mesh planeMesh;
    public List<ParticleCollisionEvent> myCollisions;
    public Ray[] rays;

	// Use this for initialization
	void Start () {
        particlePlane = GameObject.Find("Plane");
        particular = particlePlane.GetComponent<ParticleSystem>();
        
        planeMesh = particlePlane.GetComponent<MeshFilter>().mesh;
	}
    private void OnParticleCollision(GameObject other)
    {
        int howManyCollisions = particular.GetCollisionEvents(other, myCollisions);
        Rigidbody otherBody = other.GetComponent<Rigidbody>();
        for(int i = 0; i < howManyCollisions; i++)
        {
            if(otherBody)
            {
                Vector3 position = myCollisions[i].intersection;
                for(int j = 0; j < planeMesh.vertices.Length; j++)
                {
                    if (planeMesh.vertices[j] == position)
                    {

                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
