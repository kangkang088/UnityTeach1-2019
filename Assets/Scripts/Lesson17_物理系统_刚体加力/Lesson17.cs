using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour {
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start() {
        rigidBody = this.GetComponent<Rigidbody>();
        //rigidBody.AddForce(Vector3.forward * 10);
        //rigidBody.AddRelativeForce(Vector3.forward * 10);

        //rigidBody.AddTorque(Vector3.up * 10);
        //rigidBody.AddRelativeTorque(Vector3.up * 10);

        //igidBody.velocity = Vector3.forward * 5;

        rigidBody.AddExplosionForce(10, Vector3.zero, 10);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
