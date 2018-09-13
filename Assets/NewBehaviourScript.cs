using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidBodyScript : MonoBehaviour {

    private GameObject plane;
    private Rigidbody rigidThing;
    private Mesh mesh;
    private Ray[] rays;
    private Vector3 myDirection;

    // Use this for initialization
    void Start()
    {
        plane = gameObject;
        rigidThing = plane.GetComponent<Rigidbody>();
        mesh = plane.GetComponent<MeshFilter>().mesh;
        rigidThing.velocity = new Vector3(1, 0, 0);
        Vector3 planeVelocity = rigidThing.velocity;
        //direction equals planeMesh velocity normalized then multiplied by -1.0f,
        //to track objects behind it after collsion
        myDirection = planeVelocity.normalized * -1.0f;
        //Check to see if this velocity goes in opposite direction with Vector3
        rigidThing.velocity = myDirection;
        //It does!
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
